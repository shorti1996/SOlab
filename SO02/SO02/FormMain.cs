using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO02
{
    public partial class FormMain : Form
    {
        int requestCount;
        int diskSize;
        List<Request> requestList = new List<Request>();
        List<Request> requestCopy = new List<Request>();
        Random random = new Random();
        public enum algorithm { FCFS, SSTF, SCAN, CSCAN };
        public enum realtime { EDF, FDSCAN };

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGenerateRequests_Click(object sender, EventArgs e)
        {
            int reqStartMin, reqRangeMax, timeEnter, reqTimeEnterMax, reqRealTime, reqRangeEnd, reqDeadline, percent;
            Int32.TryParse(textBoxRequestsRealTime.Text, out reqRealTime);
            Int32.TryParse(textBoxRequestCount.Text, out requestCount);
            Int32.TryParse(textBoxDiskSize.Text, out diskSize);
            Int32.TryParse(textBoxRequestDeadline.Text, out reqDeadline);
            Int32.TryParse(textBoxReqestDeadlinePercent.Text, out percent);

            bool realTime = false;
            reqRealTime = requestCount * reqRealTime / 100;

            if (requestCount >= diskSize)
            {
                MessageBox.Show("Not enough space on disk to create list of non-overlaping requests");
                return;
            }

            for (int i = 0; i < requestCount; i++)
            {
                //DANGER- RECURSION
                RandomizeRange(out reqStartMin, out reqRangeMax, out reqTimeEnterMax, out reqRangeEnd);
                int reqDeadlineCalculated = 0;
                timeEnter = 0;
                if (i >= requestCount - reqRealTime)
                {
                    realTime = true;
                    timeEnter = random.Next(0, reqTimeEnterMax);
                    int percentDeadline = random.Next(-percent, percent);
                    reqDeadlineCalculated = reqDeadline - (reqDeadline * percentDeadline / 100);
                }
                Request request = new Request(reqStartMin, reqRangeEnd, timeEnter, realTime, i, reqDeadlineCalculated);
                requestList.Add(request);
            }
            requestList.Sort(Driver.SortByTimeEnter);
        }

        private static bool CheckIntersection(int reqStartMin, int reqRangeEnd, Request temp)
        {
            return temp.rangeStart <= reqRangeEnd && reqStartMin <= temp.rangeEnd;
        }

        /// <summary>
        /// Randomize start/end and recursively check if there are no overlaping requests
        /// </summary>
        /// <param name="reqStartMin"></param>
        /// <param name="reqRangeMax"></param>
        /// <param name="reqTimeEnterMax"></param>
        /// <param name="reqRangeEnd"></param>
        private void RandomizeRange(out int reqStartMin, out int reqRangeMax, out int reqTimeEnterMax, out int reqRangeEnd)
        {
            Int32.TryParse(textBoxRequestStartMin.Text, out reqStartMin);
            reqStartMin++;
            Int32.TryParse(textBoxRequestRangeMax.Text, out reqRangeMax);
            reqRangeMax = reqRangeMax * diskSize / 100;
            Int32.TryParse(textBoxRequestTimeEnterMax.Text, out reqTimeEnterMax);

            reqRangeMax = random.Next(reqRangeMax / 10, reqRangeMax);
            reqStartMin = random.Next(1, diskSize - reqRangeMax);
            //reqRangeEnd = reqStartMin + reqRangeMax;
            reqRangeEnd = reqStartMin;
            //reqRangeEnd--;

            for (int i = 0; i < requestList.Count; i++)
            {
                Request temp = requestList[i];
                if (CheckIntersection(reqStartMin, reqRangeEnd, temp))
                {
                    RandomizeRange(out reqStartMin, out reqRangeMax, out reqTimeEnterMax, out reqRangeEnd);
                    return;
                }
            }
        }

        private void buttonCreateDisk_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.FCFS, realtime.EDF);
        }

        private void CreateDisk(algorithm algorithm, realtime realtime)
        {
            Int32.TryParse(textBoxDiskSize.Text, out diskSize);
            List<Request> newList = new List<Request>();
            Driver.CopyList(requestList, out newList);
            Disk disk = new Disk(diskSize, algorithm, realtime, newList);
            disk.Show();
        }

        private void buttonCreateDiskSSTF_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.SSTF, realtime.EDF);
        }

        private void buttonCopyList_Click(object sender, EventArgs e)
        {
            Driver.CopyList(requestList, out requestCopy);
        }



        private void buttonAddCustomRequest_Click(object sender, EventArgs e)
        {
            FormAddCustomRequest formAddCustomRequest = new FormAddCustomRequest(this, requestList);
            formAddCustomRequest.Show();
        }

        private void button1CreateDiskSCAN_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.SCAN, realtime.EDF);
        }

        private void buttonCreateDiskCSCAN_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.CSCAN, realtime.EDF);
        }

        private void buttonCreateDiskFCFS_FDSCAN_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.FCFS, realtime.FDSCAN);
        }

        private void buttonCreateDiskSSTF_FDSCAN_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.SSTF, realtime.FDSCAN);
        }

        private void buttonCreateDiskSCAN_FDSCAN_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.SCAN, realtime.FDSCAN);
        }

        private void buttonCreateDiskCSCAN_FDSCAN_Click(object sender, EventArgs e)
        {
            CreateDisk(algorithm.CSCAN, realtime.FDSCAN);
        }
    }
}
