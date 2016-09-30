using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SO04.FormMain;

namespace SO04
{
    public partial class FormRAM : Form
    {
        public int virtualSize;
        public List<int> requestStream;
        public List<int> requestStreamDone = new List<int>();
        public List<Request> RequestList;
        public List<Request> RAM = new List<Request>();
        public algorithm algorithm;
        private int pageErrorCount = 0;
        public event SimulationDoneHandler SimulationDone;
        public delegate void SimulationDoneHandler(FormRAM formRam, EventArgs e);
        public event endOfStreamHandler endOfStream;
        public delegate void endOfStreamHandler(FormRAM formRAM, EventArgs e);
        Random random = new Random();
        Request currentRequest;
        public bool paused = true;
        private int physicalSize;

        public int PageErrorCount
        {
            get
            {
                return pageErrorCount;
            }

            set
            {
                pageErrorCount = value;
            }
        }

        public int PhysicalSize
        {
            get
            {
                return physicalSize;
            }

            set
            {
                physicalSize = value;
                while (RAM.Count > physicalSize)
                {
                    RAM.RemoveAt(RAM.Count - 1);
                }
            }
        }

        public FormRAM()
        {
            InitializeComponent();
        }

        public FormRAM(int physSize, int virtSize, List<int> reqStream, algorithm alg) : this()
        {
            PhysicalSize = physSize;
            virtualSize = virtSize;
            requestStream = reqStream;
            algorithm = alg;
            Driver.GenerateRequests(reqStream, out RequestList);

            //MainLoop();
        }
        
        public bool MainLoop()
        {
            while (requestStream.Count > 0)
            {
                if (algorithm == algorithm.FIFO)
                {
                    TickFIFO();
                }
                if (algorithm == algorithm.OPT)
                {
                    TickOPT();
                }
                if (algorithm == algorithm.LRU)
                {
                    TickLRU();
                }
                if (algorithm == algorithm.LRUapprox)
                {
                    TickLRUapprox();
                }
                if (algorithm == algorithm.Random)
                {
                    TickRandom();
                }
                if (currentRequest == -1)
                {
                    endOfStream(this, null);
                    Pause();
                    return false;
                }
            }
            EventArgs e = null;
            SimulationDone(this, e);
            return true;
        }

        public void Pause()
        {
            paused = true;
        }

        public void Resume()
        {
            paused = false;
            MainLoop();
        }

        private void TickRandom()
        {
            Request currentRequest;
            GetCurrentRequest(out currentRequest);
            if (RAM.Find(x => x.number == currentRequest) == null) //request not in RAM
            {
                //Report PageError
                PageErrorOccured();
                if (PhysicalSize > RAM.Count)
                {
                    RAM.Add(currentRequest);
                }
                else
                {
                    int index = random.Next(0, RAM.Count - 1);
                    RAM.RemoveAt(index);
                    RAM.Add(currentRequest);
                }
            }
            //else = request already in RAM, do nothing, handle next one
        }

        private void TickLRUapprox()
        {
            Request currentRequest;
            GetCurrentRequest(out currentRequest);
            if (RAM.Find(x => x.number == currentRequest) == null) //request not in RAM
            {
                //Report PageError
                PageErrorOccured();
                if (PhysicalSize > RAM.Count) //free frames
                {
                    RAM.Add(currentRequest);
                }
                else //no free frames
                {
                    for (int i = 0; i < RAM.Count; i++)
                    {
                        if (RAM[i].flag == false)
                        {
                            RAM.RemoveAt(i);
                            //RAM.Insert(i, currentRequest);
                            RAM.Add(currentRequest);
                            currentRequest.flag = true;
                            break;
                        }
                        if (i == RAM.Count - 1)
                        {
                            foreach (Request req in RAM)
                            {
                                req.flag = false;
                            }
                            i = -1;
                        }
                    }
                }
            }
            //else = request already in RAM, change flag, handle next one
            else
            {
                currentRequest.flag = true;
            }
        }

        private void TickLRU()
        {
            GetCurrentRequest(out currentRequest);
            if (currentRequest == -1)
            {
                return;
            }
            if (RAM.Find(x => x.number == currentRequest) == null) //request not in RAM
            {
                //Report PageError
                PageErrorOccured();
                if (PhysicalSize > RAM.Count) //free frames
                {
                    RAM.Add(currentRequest);
                }
                else //no free frames
                {
                    List<int> streamDoneReversed = new List<int>(requestStreamDone);
                    streamDoneReversed.Reverse();
                    //streamDoneReversed.RemoveRange(0, RAM.Count);
                    List<int> distances =
                        CalculateDistanceFromNextOccurence(streamDoneReversed, ConvertListRequestToListInt(RAM));
                    int index = distances.IndexOf(distances.Max());
                    Request requestToRemove = RAM.ElementAt(index);
                    RAM.Remove(RAM.Find(x => x == requestToRemove));
                    RAM.Add(currentRequest);
                }
            }
            //else = request already in RAM, do nothing, handle next one
        }

        private void TickOPT()
        {
            Request currentRequest;
            GetCurrentRequest(out currentRequest);
            if (RAM.Find(x => x.number == currentRequest) == null) //request not in RAM
            {
                //Report PageError
                PageErrorOccured();
                if (PhysicalSize > RAM.Count) //free frames
                {
                    RAM.Add(currentRequest);
                }
                else //no free frames
                {
                    List<int> distances = 
                        CalculateDistanceFromNextOccurence(requestStream, ConvertListRequestToListInt(RAM));
                    int index = distances.IndexOf(distances.Max());
                    Request requestToRemove = RAM.ElementAt(index);
                    RAM.Remove(RAM.Find(x => x == requestToRemove));
                    RAM.Add(currentRequest);
                }
            }
            //else = request already in RAM, do nothing, handle next one
        }

        private int CalculateDistanceFromNextOccurence(List<int> stream, int request)
        {
            int distance = 0;
            foreach (int number in stream)
            {
                if (number == request)
                {
                    break;
                }
                distance++;
            }
            return distance;
        }

        private List<int> CalculateDistanceFromNextOccurence(List<int> stream, List<int> requests)
        {
            List<int> distances = new List<int>();
            foreach (int request in requests)
            {
                distances.Add(CalculateDistanceFromNextOccurence(stream, request));
            }
            return distances;
        }

        private int CalculateDistanceFromPreviousOccurence(List<int> stream, int request)
        {
            int distance = 0;
            List<int> streamCopy = new List<int>(stream);
            streamCopy.Reverse();
            foreach (int number in streamCopy)
            {
                if (number == request)
                {
                    break;
                }
                distance++;
            }
            return distance;
        }

        private List<int> CalculateDistanceFromPreviousOccurence(List<int> stream, List<int> requests)
        {
            List<int> distances = new List<int>();
            foreach (int request in requests)
            {
                distances.Add(CalculateDistanceFromPreviousOccurence(stream, request));
            }
            //distances.Reverse();
            return distances;
        }

        private List<int> ConvertListRequestToListInt(List<Request> requestList)
        {
            List<int> listToReturn = new List<int>();
            foreach (Request request in requestList)
            {
                listToReturn.Add(request.number);
            }
            return listToReturn;
        }

        private void TickFIFO()
        {
            Request currentRequest;
            GetCurrentRequest(out currentRequest);
            if (RAM.Find(x => x.number == currentRequest) == null) //request not in RAM
            {
                //Report PageError
                PageErrorOccured();
                if (PhysicalSize > RAM.Count)
                {
                    RAM.Add(currentRequest);
                }
                else
                {
                    RAM.RemoveAt(0);
                    RAM.Add(currentRequest);
                }
            }
            //else = request already in RAM, do nothing, handle next one
        }

        private void GetCurrentRequest(out Request currentRequest)
        {
            int currentRequestNumber = requestStream[0];
            requestStreamDone.Add(currentRequestNumber);
            requestStream.RemoveAt(0);
            currentRequest = RequestList.Find(x => x.number == currentRequestNumber);
        }

        private void PageErrorOccured()
        {
            PageErrorCount++;
        }
    }
}
