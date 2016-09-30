using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO01
{
    public partial class FormMain : Form
    {
        Random random = new Random(); //random lifetimes
        //Guid guidGenerator = new Guid(); //GUID generator
        public List<Process> processList = new List<Process>();
        List<Process> processListCopy = new List<Process>();
        List<Process> processFuture = new List<Process>();
        List<Process> processQueued = new List<Process>();
        Process currentProcess = new Process();
        DataTable dataTableProcess = new DataTable();
        public enum algorithmUsed { FCFS, SJF, SJFP, RR };
        algorithmUsed algorithm;
        bool stop = false;
        long timePassed = 0;
        public bool done = false;
        int processCount;
        int lifeTimeMin, lifeTimeMax;
        int timeStartMin, timeStartMax;
        public int average = 0;
        int RRcounter = 0;
        int RRlimit = 10;
        Queue queue;
        List<Queue> queueList = new List<Queue>();
        List<List<int>> results = new List<List<int>>();
        System.Windows.Forms.Timer timerCheck;

        public FormMain()
        {
            dataTableProcess.Columns.Add("Name");
            dataTableProcess.Columns.Add("TimeLeft");
            dataTableProcess.Columns.Add("TimeStart");
            dataTableProcess.Columns.Add("TimeWait");
            InitializeComponent();

            int interval = 100;
            Int32.TryParse(textBoxTimerMainTick.Text, out interval);
            timerMain.Interval = interval;
            int limit = 10;
            Int32.TryParse(textBoxRRInterval.Text, out limit);
            RRlimit = limit;
        }

        public FormMain(List<Process> processList) : this()
        {
            this.processList = processList;
        }

        public FormMain(List<Process> processList, algorithmUsed algorithm, int interval = 100, int rrlimit = 10) : this(processList)
        {
            this.algorithm = algorithm;
            this.timerMain.Interval = interval;
            this.RRlimit = rrlimit;
            textBoxRRInterval.Text = RRlimit.ToString();
        }

        public FormMain(List<Process> processList, int count, int lifeTimeMin, int lifeTimeMax,
            int timeStartMin, int timeStartMax, int interval) : this()
        {
            this.processList = processList;
        }

        private void generateProcesses_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxLifeTimeMin.Text, out lifeTimeMin);
            Int32.TryParse(textBoxLifeTimeMax.Text, out lifeTimeMax);
            Int32.TryParse(textBoxProcessCount.Text, out processCount);
            Int32.TryParse(textBoxTimeStartMin.Text, out timeStartMin);
            Int32.TryParse(textBoxTimeStartMax.Text, out timeStartMax);

            for (int i = 0; i < processCount; i++)
            {
                int timeLeft = (random.Next(lifeTimeMin, lifeTimeMax)) / timerMain.Interval * timerMain.Interval;
                int timeStart = (random.Next(timeStartMin, timeStartMax)) / timerMain.Interval * timerMain.Interval;
                Process process = new Process(Guid.NewGuid().ToString(), timeLeft, i, timeStart);
                process.Name = process.id;
                process.Text = process.number + "- " + process.id;
                //process.Show();
                processList.Add(process);
                dataTableProcess.Rows.Add(process.number, process.timeLeft, process.timeStart, process.waitTime);
            }
            //generator has completed it's work
            dataGridViewProcess.DataSource = dataTableProcess;
            CopyProcesses(processList, out processListCopy);

        }

        /// <summary>
        /// Copy X to Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void CopyProcesses(List<Process> x, out List<Process> y)
        {
            y = new List<Process>();
            foreach (Process process in x)
            {
                Process processCopy = new Process(process.id, process.timeLeft, process.number, process.timeStart);
                y.Add(processCopy);
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            dataTableProcess.Clear();

            processQueued = processList.FindAll(x => (x.timeStart <= timePassed && x.timeLeft > 0));
            if (algorithm == algorithmUsed.FCFS)
            {
                PerformTick(algorithm);
            }
            if (algorithm == algorithmUsed.SJF || algorithm == algorithmUsed.SJFP)
            {
                if (processQueued.Count > 1)
                {
                    if (algorithm == algorithmUsed.SJF)
                    {
                        processQueued.RemoveAt(0);
                    }
                    int index = processList.FindIndex(x => x.id == processQueued[0].id);
                    processList.RemoveRange(index, processQueued.Count);
                    processQueued.Sort(SortingProcesses.SortByTimeLeft);
                    processList.InsertRange(index, processQueued);
                }
                PerformTick(algorithm);
            }
            if (algorithm == algorithmUsed.RR)
            {
                PerformTick(algorithm);
                if (currentProcess != null && RRcounter == RRlimit)
                {
                    processList.Remove(currentProcess);
                    processList.Add(currentProcess);
                }
                if (currentProcess == null)
                {
                    RRcounter = 0;
                }
                else
                {
                    RRcounter++;
                    if (RRcounter > RRlimit)
                    {
                        RRcounter = 0;
                    }
                }
            }
            if (processQueued.Count > 0)
            {
                processQueued.Remove(currentProcess);
            }
            foreach (Process process in processQueued)
            {
                process.waitTime += timerMain.Interval;
            }
            foreach (Process process in processList)
            {
                dataTableProcess.Rows.Add(process.number, process.timeLeft, process.timeStart, process.waitTime);
            }

            dataGridViewProcess.DataSource = dataTableProcess;
            timePassed += timerMain.Interval;
            labelTimePassedValue.Text = timePassed.ToString();

        }

        /// <summary>
        /// Method that finds current process and handles changing the numbers behind it.
        /// </summary>
        public void PerformTick(algorithmUsed type)
        {
            processList = processList.Distinct().ToList();
            currentProcess = processList.Find(x => (x.timeLeft > 0 && x.timeStart <= timePassed));
            if (currentProcess != null)
            {
                int currentIndex = processList.FindIndex(x => x.id == currentProcess.id);
                processFuture = processList.GetRange((currentIndex + 1), processList.Count - (currentIndex + 1));
                AddProcessTime(currentProcess, timerMain.Interval);
            }
            else
            {
                processFuture = processList.FindAll(x => (x.timeLeft > 0));
                if (processFuture.Count == 0)
                {
                    SimulationDone(type.ToString());
                    done = true;
                    return;
                }
            }
            if (stop == true)
            {
                timerMain.Stop();
                stop = false;
            }
        }

        private void SimulationDone(string type = "xxx")
        {
            done = true;
            timerMain.Stop();
            int average = CalculateAverage(processList);
            string message = "Average time using " + type + " was: " + average + "\nDone!";
            //MessageBox.Show(message);
            Console.WriteLine(message);
            richTextBoxAlaConsole.Text += "\n" + message + "\n";
            return;
        }

        public int CalculateAverage(List<Process> list)
        {
            average = 0;
            foreach (Process process in list)
            {
                average += process.waitTime;
            }
            average = average / list.Count;

            return average;
        }

        /// <summary>
        /// Add timeRunning, substract timeLeft
        /// </summary>
        /// <param name="process">Specified process</param>
        /// <param name="time">Time to add</param>
        private void AddProcessTime(Process process, int time)
        {
            process.AppendTimeRunning(time);
            process.SubstractTimeLeft(time);
        }

        private void buttonFCFS_Click(object sender, EventArgs e)
        {
            algorithm = algorithmUsed.FCFS;
            processList.Sort(SortingProcesses.SortByTimeStart);
            timerMain.Start();
        }

        private void buttonSJF_Click(object sender, EventArgs e)
        {
            algorithm = algorithmUsed.SJF;
            processList.Sort(SortingProcesses.SortByTimeStart);
            timerMain.Start();
        }

        public void buttonReloadProcesses_Click(object sender, EventArgs e)
        {
            processList.Clear();
            CopyProcesses(processListCopy, out processList);
            dataGridViewProcess.DataSource = dataTableProcess;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void buttonSJFP_Click(object sender, EventArgs e)
        {
            algorithm = algorithmUsed.SJFP;
            processList.Sort(SortingProcesses.SortByTimeStart);
            timerMain.Start();
        }

        private void buttonRR_Click(object sender, EventArgs e)
        {
            algorithm = algorithmUsed.RR;
            processList.Sort(SortingProcesses.SortByTimeStart);
            timerMain.Start();
        }

        private void buttonAddCustom_Click(object sender, EventArgs e)
        {
            Form addCustom = new FormAddCustom(this, processList);
            addCustom.Show();
        }

        public void buttonCloneList_Click(object sender, EventArgs e)
        {
            CopyProcesses(processList, out processListCopy);
        }

        private void labelTimePassed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearTimePassed();
        }

        private void ClearTimePassed()
        {
            timePassed = 0;
            labelTimePassedValue.Text = timePassed.ToString();
        }

        private void Reset()
        {
            buttonClearProcesses.PerformClick();
            ClearTimePassed();
        }

        private void RevertProcesses()
        {
            ClearTimePassed();
            buttonReloadProcesses.PerformClick();
        }

        private void textBoxTimerMainTick_TextChanged(object sender, EventArgs e)
        {
            int interval = 100;
            Int32.TryParse(textBoxTimerMainTick.Text, out interval);
            timerMain.Interval = interval;
        }

        private void buttonClearProcesses_Click(object sender, EventArgs e)
        {
            processFuture.Clear();
            processList.Clear();
            processListCopy.Clear();
        }

        private void textBoxRRInterval_TextChanged(object sender, EventArgs e)
        {
            int limit = 10;
            Int32.TryParse(textBoxRRInterval.Text, out limit);
            RRlimit = limit;
        }

        private void buttonBatchSimulation_Click(object sender, EventArgs e)
        {
            int simulationCount;
            Int32.TryParse(textBoxSimulationCount.Text, out simulationCount);
            for (int i = 0; i < simulationCount; i++)
            {
                Reset();
                generateProcesses.PerformClick();
                processList.Sort(SortingProcesses.SortByTimeStart);

                List<Process> listFCFS;
                CopyProcesses(processList, out listFCFS);
                FormMain formFCFS = new FormMain(listFCFS, algorithmUsed.FCFS, timerMain.Interval, RRlimit);
                //formFCFS.Show();
                formFCFS.timerMain.Start();

                List<Process> listSJF;
                CopyProcesses(processList, out listSJF);
                FormMain formSJF = new FormMain(listSJF, algorithmUsed.SJF, timerMain.Interval, RRlimit);
                //formSJF.Show();
                formSJF.timerMain.Start();

                List<Process> listSJFP;
                CopyProcesses(processList, out listSJFP);
                FormMain formSJFP = new FormMain(listSJFP, algorithmUsed.SJFP, timerMain.Interval, RRlimit);
                //formSJFP.Show();
                formSJFP.timerMain.Start();

                List<Process> listRR;
                CopyProcesses(processList, out listRR);
                FormMain formRR = new FormMain(listRR, algorithmUsed.RR, timerMain.Interval, RRlimit);
                //formRR.Show();
                formRR.timerMain.Start();

                List<FormMain> forms = new List<FormMain>();
                forms.Add(formFCFS);
                forms.Add(formSJF);
                forms.Add(formSJFP);
                forms.Add(formRR);
                Queue newQueue = new Queue(i, processList, forms);
                newQueue.waitForDone();
                queueList.Add(newQueue);
            }
            timerCheck = new System.Windows.Forms.Timer { Interval = 100 };
            timerCheck.Tick += TimerCheck_Tick;
            timerCheck.Start();
        }

        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("FCFS");
            resultsTable.Columns.Add("SJF");
            resultsTable.Columns.Add("SJFP");
            resultsTable.Columns.Add("RR");
            foreach (Queue queue in queueList)
            {
                if (queue.results.Count == 4)
                {

                    Console.WriteLine("xxxxxxxxxxxxxxx");
                    queue.results.ForEach(Console.WriteLine);
                    results.Add(queue.results);

                    
                    foreach (List<int> item in results)
                    {
                        resultsTable.Rows.Add(item[0], item[1], item[2], item[3]);
                    }
                    dataGridViewProcess.DataSource = resultsTable;
                    queueList.Remove(queue);
                    break;
                }
            }
            if (queueList.Count == 0)
            {
                System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
                timer.Stop();
                for (int i = 0; i < 4; i++)
                {
                    int averageTotal = 0;
                    foreach (List<int> resultList in results)
                    {
                        averageTotal += resultList[i];
                    }
                    averageTotal = averageTotal / results.Count;
                    string message = String.Empty;
                    switch (i)
                    {
                        case 0:
                            message = "Average of average times using FCFS is: " + averageTotal + "\n";
                            break;
                        case 1:
                            message = "Average of average times using SJF is: " + averageTotal + "\n";
                            break;
                        case 2:
                            message = "Average of average times using SJFP is: " + averageTotal + "\n";
                            break;
                        case 3:
                            message = "Average of average times using RR is: " + averageTotal + "\n";
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(message);
                    richTextBoxAlaConsole.Text += message;
                }
            }
        }
    }
}
