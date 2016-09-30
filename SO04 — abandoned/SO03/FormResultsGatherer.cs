using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SO03.FormMain;

namespace SO03
{
    public partial class FormResultsGatherer : Form
    {
        public int number, physicalSize, virtualSize;
        public List<int> requestStream;
        public List<Request> RAM = new List<Request>();
        public algorithm algorithm;
        public int PageErrorCount = 0;
        public event SimulationDoneHandler SimulationDone;
        public delegate void SimulationDoneHandler(FormResultsGatherer formResultsGatherer, EventArgs e);
        public List<List<Object>> results = new List<List<object>>();

        public FormResultsGatherer()
        {
            InitializeComponent();
        }

        public FormResultsGatherer(int number, int physSize, int virtSize, List<int> reqStream) : this()
        {
            this.number = number;
            physicalSize = physSize;
            virtualSize = virtSize;
            requestStream = reqStream;
        }

        public void StartSimulations()
        {
            foreach (algorithm alg in algorithm.GetValues(typeof(algorithm)))
            {
                List<int> requestStreamCopy = new List<int>();
                //Driver.GenerateRequests(reqStream, out RequestList);
                Driver.CopyStream(requestStream, out requestStreamCopy);
                FormRAM formRAM = new FormRAM(physicalSize, virtualSize, requestStreamCopy, alg);
                formRAM.SimulationDone += FormRAM_SimulationDone;
                //formRAM.Show();
                formRAM.MainLoop();
            }
        }

        private void FormRAM_SimulationDone(FormRAM formRam, EventArgs e)
        {
            List<object> result = new List<object>();
            result.Add(formRam.algorithm);
            result.Add(formRam.PageErrorCount);
            results.Add(result);
            if (results.Count == algorithm.GetValues(typeof(algorithm)).Length)
            {
                SimulationDone(this, e);
            }
        }
    }
}
