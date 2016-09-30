using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO02
{
    public class Request
    {
        public int number;
        public Guid id;
        public int rangeStart, rangeEnd;
        public int timeEnter;
        public bool realtime;
        public bool done = false;
        public int deadline;

        Random random = new Random();

        public Request()
        {
            this.id = Guid.NewGuid();
        }

        public Request(Request request)
        {
            this.id = request.id;
            this.done = request.done;
            this.number = request.number;
            this.rangeEnd = request.rangeEnd;
            this.rangeStart = request.rangeStart;
            this.realtime = request.realtime;
            this.timeEnter = request.timeEnter;
            this.deadline = request.deadline;
        }

        /*public Request(Disk disk) : this()
        {
            rangeEnd = random.Next(1, disk.size/10);
        }*/

        public Request(int rangeStart = 1, int rangeEnd = 20, int timeEnter = 0, bool realtime = false, int number = 0, int deadline = 20) : this ()
        {
            //this.id = Guid.NewGuid();
            this.rangeStart = rangeStart;
            this.rangeEnd = rangeEnd;
            this.timeEnter = timeEnter;
            this.realtime = realtime;
            this.number = number;
            this.deadline = deadline;
            //rangeStart = random.Next(1, rangeMax);
            //rangeEnd = random.Next(rangeStart, rangeStart + rangeMax);
        }
    }
}
