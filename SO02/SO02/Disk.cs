using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO02
{
    public partial class Disk : Form
    {
        public int size;
        public Head head;
        public List<Request> requestList = new List<Request>(); //non-realtime
        public List<Request> requestsRealTime = new List<Request>(); //realtime
        public List<Request> requestsToAdd = new List<Request>(); //request realtime for NOW
        public Timer timer = new Timer { Interval = 1 };
        public FormMain.algorithm algorithm;
        public FormMain.realtime realtimeAlgorithm;
        public int timePassed = 0;
        Request currentRequest;// = new Request();
        public List<Request> currentRequests = new List<Request>();
        public List<Request> rejectedRequests = new List<Request>();
        int RequestsFinished = 0;
        //int lastHeadPosition = -1;
        bool canPassBorder = true;

        public Disk()
        {
            head = new Head(this);
            head.Skip += new Head.TimeSkipHandler(Head_Skip);
            head.RequestFinished += Head_RequestFinished;
            head.HeadMove += Head_HeadMove;
            timer.Tick += Timer_Tick;
            InitializeComponent();
            timer.Start();
        }

        public void Head_HeadMove()
        {
            foreach (Request request in requestsToAdd)
            {
                request.deadline--;
            }
        }

        public Disk(int size, FormMain.algorithm algorithm, FormMain.realtime realtimeAlgorithm) : this()
        {
            this.size = size;
            this.algorithm = algorithm;
            this.realtimeAlgorithm = realtimeAlgorithm;
        }

        public Disk(int size, FormMain.algorithm algorithm, FormMain.realtime realtimeAlgorithm, List<Request> reqList) : this(size, algorithm, realtimeAlgorithm)
        {
            this.requestList = reqList;
            requestsRealTime = requestList.FindAll(x => (x.realtime == true));
            this.requestList.RemoveAll(x => x.realtime);
            string name = "Disk " + algorithm.ToString() + ", " + realtimeAlgorithm.ToString();
            this.Text = name;
        }

        public Disk(int size) : this()
        {
            this.size = size;
        }

        private void Head_RequestFinished(Head h, EventArgs e)
        {
            //Request currentRequest = new Request();
            RequestsFinished++;
            richTextBoxDoneRequests.Text += "\nDone: " + currentRequest?.number;
            currentRequest = null;
            /*List<Request> tempList = new List<Request>(requestList);
            if (algorithm == FormMain.algorithm.SSTF)
            {
                tempList.Sort((x, y) => Driver.SortByDistanceFromHead(x, y, head.Position));
            }
            currentRequest = tempList.Find(x => (x.done != true));*/
        }

        private void Head_Skip(Head h, int e, int time)
        {
            Console.WriteLine("Skipped from " + h.Position + " to " + (h.Position + e) + ", " + (time - timePassed) + " has passed");
            timePassed = time;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            while(true)
            {
                canPassBorder = true;
                requestList.RemoveAll(x => x.done == true);
                currentRequests.RemoveAll(x => x.done == true);
                //requestsRealTime.RemoveAll(x => x.done == true);
                //requestsToAdd.RemoveAll(x => x.done == true);
                ///////////////////
                //requestsToAdd = requestsRealTime.FindAll(x => (x.timeEnter <= timePassed));
                if (requestsRealTime.Count > 0)
                {
                    List<Request> moveables = requestsRealTime.Where(x => x.timeEnter <= timePassed).ToList();
                    requestsToAdd.AddRange(moveables);
                    moveables.ForEach(x => requestsRealTime.Remove(x));
                    /*requestsToAdd = requestsRealTime.Where(x => x.timeEnter <= timePassed).ToList();
                    requestsToAdd.ForEach(x => requestsRealTime.Remove(x));*/
                }

                head.time = timePassed;

                if (currentRequest == null)
                {
                    if (algorithm == FormMain.algorithm.FCFS)
                    {
                        if (realtimeAlgorithm == FormMain.realtime.EDF)
                        {
                            ChooseNewCurrentRequestFCFS();
                        }
                        else
                        {
                            ChooseNewCurrentRequestFCFS_FDSCAN();
                        }
                    }
                    if (algorithm == FormMain.algorithm.SSTF)
                    {
                        if (realtimeAlgorithm == FormMain.realtime.EDF)
                        {
                            ChooseNewCurrentRequestSSTF();
                        }
                        else
                        {
                            ChooseNewCurrentRequestSSTF_FDSCAN();
                        }
                    }
                    if (algorithm == FormMain.algorithm.SCAN)
                    {
                        if (realtimeAlgorithm == FormMain.realtime.EDF)
                        {
                            ChooseNewCurrentRequestSCAN();
                        }
                        else
                        {
                            ChooseNewCurrentRequestSCAN(true);
                        }
                    }
                    if (algorithm == FormMain.algorithm.CSCAN)
                    {
                        if (realtimeAlgorithm == FormMain.realtime.EDF)
                        {
                            ChooseNewCurrentRequestCSCAN();
                        }
                        else
                        {
                            ChooseNewCurrentRequestCSCAN(true);
                        }
                    }
                }
                if (currentRequest != null)
                {
                    /*if (lastHeadPosition != head.Position)
                    {
                        lastHeadPosition = head.Position;
                    }*/
                    Request toRead = currentRequests.Find(x => !x.done);
                    if (toRead != null)
                    {
                        head.ReadBlock(toRead, canPassBorder);
                    }
                    else
                    {
                        head.ReadBlock(currentRequest, canPassBorder);
                    }
                    if (head.read != true)
                    {
                        currentRequest = null;
                    }
                }
                else
                {
                    if (requestsRealTime.Count == 0 && requestList.Count == 0)
                    {
                        FinalizingTouches();
                        return;
                    }
                    else
                    {
                        timePassed += timer.Interval;
                        return;
                    }
                }
                timePassed += timer.Interval;
            }
        }

        private void ChooseNewCurrentRequestSCAN_FDSCAN()
        {
            throw new NotImplementedException();
        }

        private void ChooseNewCurrentRequestSSTF_FDSCAN()
        {
            List<Request> tempList = new List<Request>(requestList);
            tempList.Sort(Driver.SortByDistanceFromStart);
            tempList.Sort((x, y) => Driver.SortByDistanceFromHead(x, y, this));
            if (requestsToAdd.Count > 0)
            {
                //requestsToAdd.Sort((x, y) => Driver.SortByDistanceFromHead(x, y, this));
                requestsToAdd.Sort(Driver.SortByDeadline);
                tempList.InsertRange(0, requestsToAdd);
            }
            currentRequest = tempList.Find(x => (x.done != true));
            if (currentRequest != null && currentRequest.realtime)
            {
                PerformFDSCAN(tempList);
            }
        }

        private void ChooseNewCurrentRequestFCFS_FDSCAN()
        {
            List<Request> tempList = new List<Request>(requestList); //only non-realtime
            tempList.Sort(Driver.SortByTimeEnter);
            if (requestsToAdd.Count > 0)
            {
                requestsToAdd.Sort(Driver.SortByDeadline); //by deadline, not time enter
                tempList.InsertRange(0, requestsToAdd);
            }
            currentRequest = tempList.Find(x => (x.done != true));
            if (currentRequest != null && currentRequest.realtime)
            {
                PerformFDSCAN(tempList);
            }

        }

        /// <summary>
        /// Take currentRequest and check if it's reachable.
        /// If yes- fill currentRequests list with requests in-between.
        /// If no- reject currentRequest.
        /// </summary>
        /// <param name="tempList"></param>
        private void PerformFDSCAN(List<Request> tempList)
        {
            if (Driver.IsReachable(currentRequest, this))
            {
                //calculate requests between
                List<Request> listCheckBetween = new List<Request>();
                Driver.CopyList(tempList, out listCheckBetween);
                currentRequests.Clear();
                bool around;
                Request tempRequest = new Request(currentRequest);
                int distance = Driver.CalculateDistanceFromRequest(tempRequest, this, out around);
                Disk newDisk = new Disk(this.size);
                //Head newHead = new Head(newDisk); //helpful for jumping end-start/start-end
                while (newDisk.head.Position != tempRequest.rangeStart)
                {

                /*}
                for (int i = 0; i < Math.Abs(distance); i++)
                {*/
                    foreach (Request request in listCheckBetween)
                    {
                        if (request.rangeStart == newDisk.head.Position && request.realtime) //found request between and is realtime
                        {
                            Request temp = currentRequests.Find(x => request.number == x.number);
                            if (currentRequests.Find(x => request.number == x.number) == null) //!currentRequests.Contains(request)
                            {
                                currentRequests.Add(tempList.Find(x => x.number == request.number));
                            }
                            continue;
                        }
                    }
                    newDisk.head.ReadBlock(tempRequest);
                }
            }
            else
            {
                //reject current request
                rejectedRequests.Add(currentRequest);
                requestsRealTime.Remove(currentRequest);
                requestsToAdd.Remove(currentRequest);
                string message = "Couldn't handle current request because\nhead was on " + head.Position + " and current request was on " + currentRequest.rangeStart + " and " + currentRequest.deadline + " deadline";
                Console.WriteLine(message);
                richTextBoxRejectedRequests.Text += "\n" + currentRequest.number;
                currentRequest = null;
            }
        }

        private void FinalizingTouches()
        {
            timer.Stop();
            //head.positions.ForEach(Console.WriteLine);
            List<int> numbers = new List<int>();

            int delta = 0;
            foreach (int number in head.positions)
            {
                delta = Math.Abs(delta - number);
                //delta = delta - number;
                if (delta > 1)
                {
                    for (int i = 0; i < delta; i++)
                    {
                        numbers.Add(delta + i);
                    }
                }
                delta = number;
            }
            foreach (Point point in head.points)
            {
                chartResult.Series?[0].Points.AddXY(point.X, point.Y);
            }
            foreach (Point point in head.pointsMove)
            {
                chartResult.Series?[1].Points.AddXY(point.X, point.Y);
            }
            //numbers.ForEach(Console.WriteLine);
            //chartResult.Update();
            string message = "The head has travelled " + head.distance + "!";
            labelResult.Text = message;
            Console.WriteLine(message);
            richTextBoxRejectedRequests.Text += "\nTOTAL " + rejectedRequests.Count + "\n";
            richTextBoxDoneRequests.Text += "\nTOTAL " + RequestsFinished;
        }

        private void ChooseNewCurrentRequestSSTF()
        {
            List<Request> tempList = new List<Request>(requestList);
            tempList.Sort(Driver.SortByDistanceFromStart);
            tempList.Sort((x, y) => Driver.SortByDistanceFromHead(x, y, this));
            if (requestsToAdd.Count > 0)
            {
                requestsToAdd.Sort((x, y) => Driver.SortByDistanceFromHead(x, y, this));
                tempList.InsertRange(0, requestsToAdd);
                ////////
                //requestsToAdd.Clear();
            }
            currentRequest = tempList.Find(x => (x.done != true));
        }

        private void ChooseNewCurrentRequestFCFS()
        {
            List<Request> tempList = new List<Request>(requestList);
            tempList.Sort(Driver.SortByTimeEnter);
            if (requestsToAdd.Count > 0)
            {
                requestsToAdd.OrderBy(x => x.timeEnter); //stable sorting
                //requestsToAdd.Sort(Driver.SortByTimeEnter);
                tempList.InsertRange(0, requestsToAdd);
                ////////
                //requestsToAdd.Clear();
            }
            currentRequest = tempList.Find(x => (x.done != true));
        }

        private void ChooseNewCurrentRequestSCAN(bool FDSCAN = false)
        {
            canPassBorder = false;
            List<Request> tempList = new List<Request>(requestList);
            //tempList.OrderBy(x => x.rangeStart);
            tempList.Sort(Driver.SortByDistanceFromStart);

            List<Request> realtime = new List<Request>(requestsToAdd);
            //realtime.ForEach(x => tempList.Remove(x));

            realtime.OrderBy(x => x.timeEnter);
            //realtime.Sort(Driver.SortByTimeEnter);
            currentRequest = realtime.Find(x => x.done == false);
            if (currentRequest != null) //found realtime request- handle immediately
            {
                canPassBorder = true;
                if (FDSCAN)
                {
                    PerformFDSCAN(tempList);
                    return;
                }
            }
            if (currentRequest == null) //no realtime request in queue
            {
                //if (head.lastHeadPosition - head.Position <= 0) //going right
                if (head.goingRight)
                {
                    currentRequest = tempList.Find(x => (x.rangeStart >= head.Position && x.done != true)); //find further right request
                    if (currentRequest == null && tempList.Count > 0)
                    {
                        if (head.Position < this.size)
                        {
                            head.GoBeyondTheEdge(); //go to right end
                            return;
                        }
                        if (head.Position == this.size)
                        {
                            head.GoBeyondTheEdge(false); //change direction
                            //canPassBorder = false;
                            return;
                        }
                    }
                    return;
                }
                else // going left
                {
                    currentRequest = tempList.FindLast(x => (x.rangeStart <= head.Position && x.done != true)); //find further left request
                    if (currentRequest == null && tempList.Count > 0)
                    {
                        if (head.Position > 1)
                        {
                            head.GoBeyondTheEdge(false); //go to left end
                            return;
                        }
                        if (head.Position == 1)
                        {
                            head.GoBeyondTheEdge(); //change direction
                            //canPassBorder = false;
                            return;
                        }
                        return;
                    }
                }
            }
        }

        private void ChooseNewCurrentRequestCSCAN(bool FDSCAN = false)
        {
            List<Request> tempList = new List<Request>(requestList);
            tempList.Sort(Driver.SortByDistanceFromStart);

            List<Request> realtime = new List<Request>(requestsToAdd);
            //realtime.ForEach(x => tempList.Remove(x));

            //realtime
            //realtime sort timeenter
            //non-realtime
            //
            realtime.OrderBy(x => x.timeEnter);
            //realtime.Sort(Driver.SortByTimeEnter);
            currentRequest = realtime.Find(x => x.done == false);
            if (currentRequest != null && currentRequest.realtime && FDSCAN == true)
            {
                PerformFDSCAN(tempList);
                return;
            }
            if (currentRequest == null) //no realtime requests in queue
            {
                if (head.goingRight)
                {
                    currentRequest = tempList.Find(x => (x.rangeStart >= head.Position && x.done != true));
                    if (currentRequest == null && tempList.Count > 0)
                    {
                        head.GoBeyondTheEdge();
                        return;
                    }
                }
                else
                {
                    currentRequest = tempList.FindLast(x => (x.rangeStart <= head.Position && x.done != true)); //find further left request
                    if (currentRequest == null && tempList.Count > 0)
                    {
                        head.GoBeyondTheEdge(false);
                        return;
                    }
                }
            }
        }

    }
}
