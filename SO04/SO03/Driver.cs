using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO04
{
    class Driver
    {
        public static void CopyStream(List<int> x, out List<int> y)
        {
            y = new List<int>();
            foreach (int req in x)
            {
                y.Add(req);
            }
        }

        public static void GenerateRequests(List<int> reqStream, out List<Request> RequestList)
        {
            RequestList = new List<Request>();
            foreach (int number in reqStream)
            {
                if (RequestList.Find(x => x.number == number) == null) //there is no such request yet
                {
                    Request newRequest = new Request(number);
                    RequestList.Add(newRequest);
                }
            }
        }

    }
}
