using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO01
{
    public class SortingProcesses
    {
        public static int SortByTimeLeft(Process x, Process y)
        {
            if (x.timeLeft < y.timeLeft)
            {
                return -1;
            }
            if (x.timeLeft == y.timeLeft)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            return -1;
        }
        public static int SortByTimeStart(Process x, Process y)
        {
            if (x.timeStart < y.timeStart)
            {
                return -1;
            }
            if (x.timeStart == y.timeStart)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            return -1;
        }
        public static int SortByTimeNeeded(Process x, Process y)
        {
            if (x.timeNeeded < y.timeNeeded)
            {
                return -1;
            }
            if (x.timeNeeded == y.timeNeeded)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            return -1;
        }
    }
}
