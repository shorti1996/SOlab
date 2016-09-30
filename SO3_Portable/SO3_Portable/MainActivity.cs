using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace SO3_Portable
{
    [Activity(Label = "SO3_Portable", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int requestCount, physicalMemorySize, virtualMemorySize, localityOfReferenceChance, localityOfReferenceParts, localityOfReferenceDensity;
        int framesMin, framesIterations, framesStep;
        public List<int> requestStream;
        public List<Request> requestList;
        public List<Request> PhysicalMemory;
        public enum algorithm { FIFO, OPT, LRU, LRUapprox, Random };

        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

