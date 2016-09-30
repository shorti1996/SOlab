using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO03
{
    public partial class FormMain : Form
    {
        int requestCount, physicalMemorySize, virtualMemorySize, localityOfReferenceChance, localityOfReferenceParts, localityOfReferenceDensity;
        int framesMin, framesIterations, framesStep;
        public List<int> requestStream;
        public List<Request> requestList;
        public List<Request> PhysicalMemory;
        public enum algorithm {FIFO, OPT, LRU, LRUapprox, Random};
        public DataTable dataTableResults = new DataTable();

        public FormMain()
        {
            InitializeComponent();
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
                ReadPhysicalMemSize();
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

        private void PerformSimulation(algorithm algorithm)
        {
            if (requestStream == null)
            {
                return;
            }
            ReadPhysicalMemSize();
            List<int> requestStreamCopy = new List<int>();
            Driver.CopyStream(requestStream, out requestStreamCopy);
            FormRAM formRAM = new FormRAM(physicalMemorySize, virtualMemorySize, requestStreamCopy, algorithm);
            formRAM.SimulationDone += FormRAM_SimulationDone;
            formRAM.MainLoop();
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
            dataGridViewResults.Rows.Add(index, formRam.physicalSize, formRam.requestStreamDone.Count, 0, 0, 0);
            string query = formRam.algorithm.ToString();
            index = dataGridViewResults.Columns[query].Index;
            dataGridViewResults.Rows[dataGridViewResults.Rows.Count - 2].Cells[index].Value = formRam.PageErrorCount;
            Console.WriteLine(formRam.algorithm.ToString() + " , " + formRam.PageErrorCount);
        }

        private void buttonGenerateRequests_Click(object sender, EventArgs e)
        {
            requestStream = new List<int>();
            ReadPhysicalMemSize();
            int.TryParse(textBoxVirtualMemSize.Text, out virtualMemorySize);
            int.TryParse(textBoxRequestsCount.Text, out requestCount);
            Random random = new Random();

            int k = 0;
            for (int i = 0; i < requestCount; i++)
            {
                if (!checkBoxLocalityOfReference.Checked)
                {
                    int number = random.Next(1, virtualMemorySize+1);
                    if (requestStream.Count > 0 && number == requestStream[requestStream.Count-1])
                    {
                        number++;
                    }
                    requestStream.Add(number);
                }
                else
                {
                    /*int.TryParse(textBoxLocalityOfReferenceChance.Text, out localityOfReferenceChance);
                    int.TryParse(textBoxLocalityOfReferenceParts.Text, out localityOfReferenceParts);
                    int partitionSize = requestCount / localityOfReferenceParts;

                    for (int j = 0; j < partitionSize; j++)
                    {
                        int local = random.Next(0, 100);
                        int number = 0;
                        if (requestStream.Count > 0)
                        {
                            if (local <= localityOfReferenceChance)
                            {
                                number = requestStream[requestStream.Count - 1] + 1;
                                requestStream.Add(number);
                                i++;
                                continue;
                            }
                        }

                        number = random.Next(partitionSize * k, partitionSize * (k + 1));
                        requestStream.Add(number);
                        i++;
                    }*/

                    int.TryParse(textBoxLocalityOfReferenceChance.Text, out localityOfReferenceChance);
                    int.TryParse(textBoxLocalityOfReferenceParts.Text, out localityOfReferenceParts);
                    int.TryParse(textBoxLocalityOfReferenceDensity.Text, out localityOfReferenceDensity);
                    int partitionSize = requestCount / localityOfReferenceParts;
                    int number = random.Next(0, 100+1);
                    if (number <= localityOfReferenceChance)
                    {
                        if (requestStream.Count > 0)
                        {
                            number = requestStream[requestStream.Count - 1];
                        }
                        else
                        {
                            number = random.Next(0, virtualMemorySize+1);
                        }
                        int min = number - localityOfReferenceDensity * virtualMemorySize / 100;
                        if (min < 1)
                            min = 1;
                        int max = number + localityOfReferenceDensity * virtualMemorySize / 100;
                        if (max > virtualMemorySize)
                            max = virtualMemorySize;
                        number = random.Next(min, max+1);
                    }
                    else
                    {
                        number = random.Next(1, virtualMemorySize+1);
                    }
                    requestStream.Add(number);
                }
                k++;
            }
        }

        private void ReadPhysicalMemSize()
        {
            int.TryParse(textBoxPhysicalMemSize.Text, out physicalMemorySize);
        }
    }


}
