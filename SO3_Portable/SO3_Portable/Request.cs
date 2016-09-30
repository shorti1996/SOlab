using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SO3_Portable
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