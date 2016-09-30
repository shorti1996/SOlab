using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO02
{
    public partial class FormAddCustomRequest : Form
    {
        List<Request> requestList;

        public FormAddCustomRequest(FormMain formMain, List<Request> requestList)
        {
            this.requestList = requestList;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int timeEnter = 0;
            int number;// = 0;
            int rangeStart, rangeEnd;
            bool realtime;
            Int32.TryParse(textBoxTimeEnter.Text, out timeEnter);
            Int32.TryParse(textBoxRequestStart.Text, out rangeStart);
            Int32.TryParse(textBoxRequestEnd.Text, out rangeEnd);
            Boolean.TryParse(comboBox1.Text, out realtime);

            number = requestList.Count;
            Request newRequest = new Request(rangeStart, rangeEnd, timeEnter, realtime, number);
            newRequest.id = Guid.NewGuid();
            requestList.Add(newRequest);
            Debug.WriteLine("Added a new request!");
        }
    }
}
