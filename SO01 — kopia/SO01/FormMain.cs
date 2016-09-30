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
    public partial class FormMain : Form
    {
        Random random = new Random(); //random lifetimes
        //Guid guidGenerator = new Guid(); //GUID generator
        List<Process> processList = new List<Process>();
        List<Process> processListCopy = new List<Process>();
        List<Process> processFuture = new List<Process>();
        List<Process> processQueued = new List<Process>();
        Process currentProcess = new Process();
        TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, 100); //100 ms
        DataTable dataTableProcess = new DataTable();
        public enum algorithmUsed { FCFS, SJF, SJFP, RR };
        algorithmUsed algorithm;
        bool stop = false;
        long timePassed = 0;
        Boolean done = false;

        public FormMain()
        {
            dataTableProcess.Columns.Add("Name");
            dataTableProcess.Columns.Add("TimeLeft");
            dataTableProcess.Columns.Add("TimeStart");
            dataTableProcess.Columns.Add("TimeWait");
            InitializeComponent();
        }

        private void generateProcesses_Click(object sender, EventArgs e)
        {
            int count;
            int lifeTimeMin, lifeTimeMax;
            int timeStartMin, timeStartMax;
            Int32.TryParse(textBoxLifeTimeMin.Text, out lifeTimeMin);
            Int32.TryParse(textBoxLifeTimeMax.Text, out lifeTimeMax);
            Int32.TryParse(textBoxProcessCount.Text, out count);
            Int32.TryParse(textBoxTimeStartMin.Text, out timeStartMin);
            Int32.TryParse(textBoxTimeStartMax.Text, out timeStartMax);
            int interval = 100;
            Int32.TryParse(textBoxTimerMainTick.Text, out interval);
            timerMain.Interval = interval;

            for (int i = 0; i < count; i++)
            {
                int timeLeft = (random.Next(lifeTimeMin, lifeTimeMax)) / timerMain.Interval * timerMain.Interval;
                int timeStart = (random.Next(timeStartMin, timeStartMax)) / timerMain.Interval * timerMain.Interval;
                //timeLeft = timeLeft / 100;
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
        private static void CopyProcesses(List<Process> x, out List<Process> y)
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
                if (currentProcess != null)
                {
                    processList.Remove(currentProcess);
                    processList.Add(currentProcess);

                    //currentProcess.waitTime -= timerMain.Interval;
                }

            }

            /*foreach (Process process in processFuture)
            {
                process.waitTime += timerMain.Interval;
            }*/
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
            MessageBox.Show(message);
            Console.WriteLine(message);
            return;
        }

        public int CalculateAverage(List<Process> list)
        {
            int average = 0;
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
            /*currentProcess.AppendTimeRunning(timerMain.Interval);
            currentProcess.SubstractTimeLeft(timerMain.Interval);*/
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

        private void buttonReloadProcesses_Click(object sender, EventArgs e)
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

        private void buttonCloneList_Click(object sender, EventArgs e)
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

        private void buttonClearProcesses_Click(object sender, EventArgs e)
        {
            processFuture.Clear();
            processList.Clear();
            processListCopy.Clear();
        }

        private void buttonBatchSimulation_Click(object sender, EventArgs e)
        {
            generateProcesses.PerformClick();
            buttonFCFS.PerformClick();
            while (!done)
            {
            }
        }
    }
}
