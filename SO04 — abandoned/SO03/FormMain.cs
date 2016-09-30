using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SO03.FormManager;

namespace SO03
{
    public partial class FormMain : Form
    {
        public int number;
        public int requestCount, physicalMemorySize, virtualMemorySize, localityOfReferenceChance, localityOfReferenceParts, localityOfReferenceDensity;
        public int framesMin, framesIterations, framesStep;
        public int endOfStreamChance = 30;
        public List<int> requestStream;
        public List<int> requestStreamDone = new List<int>();
        public List<Request> requestList;
        public List<Request> PhysicalMemory;
        public enum algorithm {FIFO, OPT, LRU, LRUapprox, Random};
        public int pageErrorCount = 0;
        public int framesCount = 0;
        public event endOfStreamHandler endOfStream;
        public delegate void endOfStreamHandler(FormMain formMain, EventArgs e);
        public FormRAM formRAM;


        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(int num) : this()
        {
            number = num;
        }

        public FormMain(List<InitializationObject> init, int num = 0) : this(num)
        {
            foreach (var setting in init)
            {
                var type = this.GetType();
                var field = type.GetField("framesMin");
                field.SetValue(this, setting.value);
            }
        }

        private void buttonRunMany_Click(object sender, EventArgs e)
        {
            if (requestStream == null)
            {
                return;
            }
            int.TryParse(textBoxFramesMin.Text, out framesMin);
            int.TryParse(textBoxFramesMax.Text, out framesIterations);
            int.TryParse(textBoxFramesStep.Text, out framesStep);
            int i = 1;
            while (i <= framesIterations)
            {
                ReadFromForm();
                List<int> requestStreamCopy = new List<int>();
                Driver.CopyStream(requestStream, out requestStreamCopy);
                FormResultsGatherer formResultsGatherer = new FormResultsGatherer(i, framesMin, virtualMemorySize, requestStreamCopy);
                formResultsGatherer.SimulationDone += FormResultsGatherer_SimulationDone;
                formResultsGatherer.StartSimulations();
                framesMin += framesStep;
                i++;
            }
        }

        private void buttonLRU_Click(object sender, EventArgs e)
        {
            PerformSimulation(algorithm.LRU);
        }

        private void buttonLRUapprox_Click(object sender, EventArgs e)
        {
            PerformSimulation(algorithm.LRUapprox);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            PerformSimulation(algorithm.Random);
        }

        private void buttonClearDataGridViewResults_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Rows.Clear();
        }

        private void checkBoxLocalityOfReference_CheckedChanged(object sender, EventArgs e)
        {
            panelLocalityOfReference.Enabled = checkBoxLocalityOfReference.Checked;
        }

        private void FormResultsGatherer_SimulationDone(FormResultsGatherer formResultsGatherer, EventArgs e)
        {
            dataGridViewResults.Rows.Add(formResultsGatherer.number, formResultsGatherer.physicalSize, formResultsGatherer.requestStream.Count, formResultsGatherer.results[0][1], formResultsGatherer.results[1][1], formResultsGatherer.results[2][1], formResultsGatherer.results[3][1], formResultsGatherer.results[4][1]);
            if (dataGridViewResults.Rows.Count % framesIterations == 0)
            {
                FormFinished ff = new FormFinished();
                ff.Show();
            }
        }

        private void buttonFIFO_Click(object sender, EventArgs e)
        {
            PerformSimulation(algorithm.FIFO);
        }

        public void PerformSimulation(algorithm algorithm = algorithm.LRU)
        {
            InitializeSimulation(algorithm);
            formRAM.MainLoop();
        }

        public void InitializeSimulation(algorithm algorithm = algorithm.LRU)
        {
            if (requestStream == null)
            {
                return;
            }
            if (virtualMemorySize == 0)
            {
                ReadFromForm();
            }
            List<int> requestStreamCopy = new List<int>();
            Driver.CopyStream(requestStream, out requestStreamCopy);
            formRAM = new FormRAM(physicalMemorySize, virtualMemorySize, requestStreamCopy, algorithm);
            formRAM.CurrentForm = this;
            //formRAM.SimulationDone += FormRAM_SimulationDone;
            formRAM.endOfStream += FormRAM_endOfStream;
        }

        private void FormRAM_endOfStream(FormRAM formRAM, EventArgs e)
        {
            formRAM.Pause();
            endOfStream(this, null);
        }

        private void buttonOPT_Click(object sender, EventArgs e)
        {
            PerformSimulation(algorithm.OPT);
        }

        public void FormRAM_SimulationDone(FormRAM formRam, EventArgs e)
        {
            int index = 0;
            if (dataGridViewResults.Rows.Count > 1)
            {
                index = int.Parse(dataGridViewResults.Rows[dataGridViewResults.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
            }
            dataGridViewResults.Rows.Add(index, formRam.PhysicalSize, formRam.requestStreamDone.Count, 0, 0, 0);
            string query = formRam.algorithm.ToString();
            index = dataGridViewResults.Columns[query].Index;
            dataGridViewResults.Rows[dataGridViewResults.Rows.Count - 2].Cells[index].Value = formRam.PageErrorCount;
            Console.WriteLine(formRam.algorithm.ToString() + " , " + formRam.PageErrorCount);
        }

        private void buttonGenerateRequests_Click(object sender, EventArgs e)
        {
            GenerateRequests();
        }

        public void GenerateRequests()
        {
            requestStream = new List<int>();
            if (virtualMemorySize == 0)
            {
                ReadFromForm();
            }

            Random random = new Random();

            for (int i = 0; i < requestCount; i++)
            {
                int number = random.Next(0, 101);
                if (number <= endOfStreamChance)
                {
                    requestStream.Add(-1);
                    continue;
                }
                number = random.Next(0, 101);
                if (number <= localityOfReferenceChance)
                {
                    if (requestStream.Count > 0 && requestStream[requestStream.Count - 1] != -1)
                    {
                        number = requestStream[requestStream.Count - 1] + 1;
                        if (number > virtualMemorySize)
                        {
                            number = 1;
                        }
                        requestStream.Add(number);
                        continue;
                    }
                    else
                    {
                        requestStream.Add(random.Next(1, virtualMemorySize + 1));
                        continue;
                    }
                }
                requestStream.Add(random.Next(1, virtualMemorySize + 1));
            }
        }

        private void ReadFromForm()
        {
            int.TryParse(textBoxPhysicalMemSize.Text, out physicalMemorySize);
            int.TryParse(textBoxLocalityOfReferenceChance.Text, out localityOfReferenceChance);
            int.TryParse(textBoxLocalityOfReferenceParts.Text, out localityOfReferenceParts);
            int.TryParse(textBoxLocalityOfReferenceDensity.Text, out localityOfReferenceDensity);
            int.TryParse(textBoxVirtualMemSize.Text, out virtualMemorySize);
            int.TryParse(textBoxRequestsCount.Text, out requestCount);
        }

        public void Pause()
        {
            formRAM.Pause();
        }

        public void Resume()
        {
            formRAM.Resume();
        }
    }
}
