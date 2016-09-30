using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO01
{
    public partial class Process : Form
    {
        //numer,	 dł. fazy procesora,	 moment	 zgłoszenia	 się,	 czas	oczekiwania	/początkowo równy	0/
        public string id;
        public int number;
        public int timeLeft;
        public int TimeRunning;
        public int timeNeeded;
        public int timeStart;
        public int waitTime = 0;

        public Process()
        {
            InitializeComponent();
        }
        public Process(String id, int timeN)
        {
            this.id = id.ToString();
            //MessageBox.Show("My GUID is: " + this.id);
            timeNeeded = timeN;
            timeLeft = timeNeeded;
            //timeStart = DateTime.Now;

            InitializeComponent();
            textBoxTimeLeft.Text = timeLeft.ToString();
        }
        public Process(String id, int timeL, int number) : this(id, timeL)
        {
            this.number = number;
        }
        public Process(String id, int timeL, int number, int timeS) : this(id, timeL, number)
        {
            this.timeStart = timeS;
        }

        public void AppendTimeRunning(int time)
        {
            int current;
            Int32.TryParse(textBoxTimeRunning.Text, out current);
            current += time;
            textBoxTimeRunning.Text = current.ToString();
        }
        public void SubstractTimeLeft(int time)
        {
            int current;
            Int32.TryParse(textBoxTimeLeft.Text, out current);
            current -= time;
            timeLeft = current;
            textBoxTimeLeft.Text = current.ToString();
        }
    }
}
