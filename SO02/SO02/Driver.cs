using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO02
{
    class Driver
    {
        public Driver(FormMain.algorithm algorithmUsed)
        {

        }

        public static int SortByTimeEnter(Request x, Request y)
        {
            if (x.timeEnter < y.timeEnter)
            {
                return -1;
            }
            if (x.timeEnter == y.timeEnter)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static int SortByDistanceFromHead(Request x, Request y, Disk disk)
        {
            int distanceFromX, distanceFromY;
            bool around;
            distanceFromX = CalculateDistanceFromRequest(x, disk, out around);
            distanceFromY = CalculateDistanceFromRequest(y, disk, out around);

            if (distanceFromX < distanceFromY)
            {
                return -1;
            }
            if (distanceFromX == distanceFromY)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static int SortByDirectionFromHead(Request x, Request y, int position)
        {
            int distanceFromX, distanceFromY;
            int distanceFromXStart = position - x.rangeStart;
            int distanceFromXEnd = position - x.rangeEnd;
            int distanceFromYStart = position - y.rangeStart;
            int distanceFromYEnd = position - y.rangeEnd;

            if (Math.Abs(distanceFromXEnd) > Math.Abs(distanceFromXStart))
            {
                distanceFromX = distanceFromXStart;
            }
            else distanceFromX = distanceFromXEnd;

            if (Math.Abs(distanceFromYEnd) > Math.Abs(distanceFromYStart))
            {
                distanceFromY = distanceFromYStart;
            }
            else distanceFromY = distanceFromYEnd;

            if (distanceFromX < distanceFromY)
            {
                return -1;
            }
            if (distanceFromX == distanceFromY)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static int SortByDistanceFromStart(Request x, Request y)
        {
            int distanceFromX, distanceFromY;
            distanceFromX = x.rangeStart;
            distanceFromY = y.rangeStart;

            if (distanceFromX < distanceFromY)
            {
                return -1;
            }
            if (distanceFromX == distanceFromY)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static int SortByDeadline(Request x, Request y)
        {
            int deadlineX, deadlineY;
            deadlineX = x.deadline;
            deadlineY = y.deadline;

            if (deadlineX < deadlineY)
            {
                return -1;
            }
            if (deadlineX == deadlineY)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static void CopyList(List<Request> x, out List<Request> y)
        {
            y = new List<Request>();
            foreach (Request request in x)
            {
                Request newRequest = new Request(request.rangeStart, request.rangeEnd, request.timeEnter, request.realtime, request.number);
                newRequest.id = request.id;
                newRequest.deadline = request.deadline;
                y.Add(newRequest);
            }
        }

        public static int CalculateDistanceFromRequest(Request request, Disk disk, out bool around)
        {
            around = false;
            int distance = 0;
            int distanceFromXStart = CalculateDistanceFromPoint(request.rangeStart, disk, out around);
            int distanceFromXEnd = CalculateDistanceFromPoint(request.rangeEnd, disk, out around);
            //compare start to end
            if (distanceFromXEnd >= distanceFromXStart)
            {
                distance = distanceFromXStart;
                return distance;
            }
            if (distanceFromXEnd < distanceFromXStart)
            {
                distance = distanceFromXEnd;
                return distance;
            }
            else return distance;
        }

        public static int CalculateDistanceFromPoint(int point, Disk disk, out bool around)
        {
            /*if (head == null)
            {
                head = disk.head;
            }*/
            around = false;
            int distanceFromPoint = Math.Abs(disk.head.Position - point);
            int distanceFromPointWayAround = Math.Abs(disk.size - distanceFromPoint);
            if (distanceFromPoint > distanceFromPointWayAround)
            {
                distanceFromPoint = distanceFromPointWayAround;
                around = true;
            }
            return distanceFromPoint;
        }

        public static bool IsReachable(Request request, Disk disk)
        {
            bool dummyBoolean;
            bool toReturn;
            if ((CalculateDistanceFromRequest(request, disk, out dummyBoolean) <= request.deadline))
            {
                toReturn = true;
            }
            else
            {
                toReturn = false;
            }
            return toReturn;
        }

    }   
}
