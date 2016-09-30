using System;

namespace SO03
{
    public class Request
    {
        public int number;
        public bool flag = true;

        public Request(int number)
        {
            this.number = number;
        }

        public static implicit operator int(Request v)
        {
            return v.number;
        }
    }
}