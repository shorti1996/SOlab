using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO02
{
    public class Head
    {
        private int position;
        public int distance;
        public int time = 0;
        public List<int> positions = new List<int>();
        public List<Point> points = new List<Point>();
        public List<Point> pointsMove = new List<Point>();
        public Disk disk;

        EventArgs e = null;
        public event TimeSkipHandler Skip;
        public delegate void TimeSkipHandler(Head h, int e, int time);
        public event RequestFinishedHandler RequestFinished;
        public delegate void RequestFinishedHandler(Head h, EventArgs e);
        public event HeadMovedHandler HeadMove;
        public delegate void HeadMovedHandler();
        public bool read = false;
        public int lastHeadPosition = -1;
        public bool goingRight = true;

        public int Position
        {
            get
            {
                return position;
            }

            set
            {
                //backup last position
                if (lastHeadPosition != this.Position)
                {
                    lastHeadPosition = this.Position;
                }
                //determine direction
                if (lastHeadPosition < value)
                {
                    goingRight = true;
                }
                else
                {
                    goingRight = false;
                }
                //correct direction
                if (lastHeadPosition == disk.size && value == 1)
                {
                    goingRight = true;
                }
                if (lastHeadPosition == 1 && value == disk.size)
                {
                    goingRight = false;
                }
                //SET POSITION
                position = value;
                if (position > disk.size)
                {
                    position = 1;
                }
                if (position < 1)
                {
                    position = disk.size;
                }
                if (HeadMove!=null)
                {
                     HeadMove(); //raise event
                }
                //positions.Add(position);
                if (read)
                {
                    points.Add(new Point(position, (int)time));
                }
                else
                    pointsMove.Add(new Point(position, (int)time));
            }
        }

        public Head(Disk disk)
        {
            this.disk = disk;
            Position = 1;
            distance = 0;
        }

        public Head(Head head)
        {
            this.disk = head.disk;
            Position = head.Position;
        }

        public void MoveHead(int delta)
        {
            Position += delta;
            distance += Math.Abs(delta);
        }

        public void MoveHeadToBlock(int block, bool around = false)
        {
            if (block > Position)
            {
                if (around == true)
                {
                    MoveHead(-1);
                }
                else
                {
                    MoveHead(1);
                }
                return;
            }
            else
            {
                if (around == true)
                {
                    MoveHead(1);
                }
                else
                {
                    MoveHead(-1);
                }
                return;
            }
        }

        /// <summary>
        /// Detect whether go to request.rangeStart or request.rangeEnd and which way
        /// </summary>
        /// <param name="request"></param>
        private void MoveHeadToEdge(Request request, bool canPassBorder = true)
        {
            bool around = false;
            Driver.CalculateDistanceFromRequest(request, disk, out around);
            around = canPassBorder && around; //logic AND (canPassBorder = can, around = should)
            if (Position < request.rangeStart)
            {
                read = false;
                MoveHeadToBlock(request.rangeStart, around);
                return;
            }
            if (Position >= request.rangeStart && Position <= request.rangeEnd)
            {
                read = true;
                int deltaStart, deltaEnd;
                deltaStart = Position - request.rangeStart;
                deltaEnd = request.rangeEnd - Position;
                if (deltaStart <= deltaEnd)
                {
                    MoveHeadToBlock(request.rangeStart);
                    return;
                }
                else
                {
                    MoveHeadToBlock(request.rangeEnd);
                    return;
                }
            }
            else
            {
                read = false;
                MoveHeadToBlock(request.rangeEnd, around);
                return;
            }
        }

        /// <summary>
        /// Read or move to edge of the given request
        /// </summary>
        /// <param name="request"></param>
        public void ReadBlock(Request request, bool canPassBorder = true)
        {
            if (request.rangeStart > request.rangeEnd)
            {
                request.done = true;
                if (RequestFinished != null)
                {
                    RequestFinished(this, e);
                }
                MakeLastPointMove();
                return;
            }

            if (Position == request.rangeStart && goingRight)
            {
                request.rangeStart++;
                read = true;
                MakeLastPointRead();
                Position++;
                //MoveHeadToEdge(request);
                return;
            }
            if (Position == request.rangeEnd && !goingRight)
            {
                request.rangeEnd--;
                read = true;
                MakeLastPointRead();
                Position--;
                //MoveHeadToEdge(request);
                return;
            }
            MoveHeadToEdge(request, canPassBorder);
        }

        private void MakeLastPointRead()
        {
            if (pointsMove.Count == 0)
            {
                return;
            }
            Point point = pointsMove.Last();
            pointsMove.Remove(point);
            points.Add(point);
        }

        private void MakeLastPointMove()
        {
            if (points.Count == 0)
            {
                return;
            }
            Point point = points.Last();
            points.Remove(point);
            pointsMove.Add(point);
        }

        public void GoBeyondTheEdge(bool right = true)
        {
            read = false;
            if (right)
            {
                Position++;
            }
            else
            {
                Position--;
            }
        }

    }
}
