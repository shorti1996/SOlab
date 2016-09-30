using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO01
{
    class Queue
    {
        int id;
        List<Process> processList;
        bool done = false;
        public List<FormMain> forms;
        public List<int> results = new List<int>();
        System.Windows.Forms.Timer timerCheck;

        public Queue(int id, List<Process> list, List<FormMain> forms)
        {
            this.forms = forms;
            this.id = id;
            this.processList = list;
        }

        public void waitForDone()
        {
            timerCheck = new System.Windows.Forms.Timer() { Interval = 10 };
            timerCheck.Tick += TimerCheck_Tick;
            timerCheck.Start();
        }

        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            int i = 0;
            foreach (FormMain form in forms)
            {
                if (form.done == true)
                {
                    i++;
                }
            }
            if (i == forms.Count)
            {
                timerCheck.Stop();
                done = true;
                results = RetrieveTimes();
            }
        }

        public List<int> RetrieveTimes()
        {
            List<int> times = new List<int>();
            foreach (FormMain form in forms)
            {
                times.Add(form.average);
            }
            times.ForEach(Console.WriteLine);
            return times;
        }

    }
}
