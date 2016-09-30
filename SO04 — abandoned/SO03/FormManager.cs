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
    public partial class FormManager : Form
    {
        List<FormMain> listOfMains = new List<FormMain>();
        List<FormMain> listOfMainsCopy;
        public FormManager()
        {
            InitializeComponent();


            List<InitializationObject> init = new List<InitializationObject>();
            init.Add(new InitializationObject("framesMin", 22));
            init.Add(new InitializationObject("requestCount", 10));
            init.Add(new InitializationObject("virtualMemorySize", 100));
            init.Add(new InitializationObject("physicalMemorySize", 10));
            init.Add(new InitializationObject("localityOfReferenceChance", 70));
            init.Add(new InitializationObject("endOfStreamChance", 30));

            for (int i = 0; i < 2; i++)
            {
                FormMain fm = new FormMain(init, i);
                listOfMains.Add(fm);
                fm.Show();
                fm.GenerateRequests();
                //fm.PerformSimulation(FormMain.algorithm.LRU);
            }
            foreach (FormMain fm in listOfMains)
            {
                fm.InitializeSimulation();
                fm.endOfStream += Fm_endOfStream;
                fm.formRAM.SimulationDone += FormMain_FormRAM_SimulationDone;
            }
            listOfMainsCopy = new List<FormMain>(listOfMains);
            //FormRAM fr = new FormRAM(5, 10, listOfMains[0].requestStream);
            PerformSimulation(listOfMains[0]);
        }

        public class InitializationObject
        {
            public string name;
            public Object value;
            public InitializationObject(string n, object o)
            {
                name = n;
                value = o;
            }
        }

        public void PerformSimulation(FormMain firstMain)
        {
            if (firstMain.requestStream == null)
            {
                return;
            }
            firstMain.Resume();

            //Driver.CopyStream(fm.requestStream, out requestStreamCopy);

            /*FormRAM formRAM = new FormRAM(firstMain.physicalMemorySize, firstMain.virtualMemorySize, firstMain.requestStream);
            formRAM.CurrentForm = firstMain;
            formRAM.SimulationDone += FormRAM_SimulationDone;
            formRAM.endOfStream += FormRAM_endOfStream;
            formRAM.MainLoop();*/
        }

        private void FormMain_FormRAM_SimulationDone(FormRAM formRam, EventArgs e)
        {
            listOfMainsCopy.Add(formRam.CurrentForm);
            int index = listOfMains.FindIndex(x => (x.formRAM.CurrentForm.number == formRam.CurrentForm.number));
            if (index >= 0)
            {
                listOfMains.RemoveAt(index);
            }
            if (listOfMains.Count > 0)
            {
                Fm_endOfStream(formRam.CurrentForm, null);
            }
            else
            {
                Console.WriteLine("DONE");
            }
        }

        private void Fm_endOfStream(FormMain formMain, EventArgs e)
        {
            FormMain nextForm = GetNextFormMain(formMain.formRAM.CurrentForm);
            nextForm.Resume();
        }

        private void FormRAM_endOfStream(FormRAM formRAM, EventArgs e)
        {
            FormMain nextForm = GetNextFormMain(formRAM.CurrentForm);
            reloadRequestStream(formRAM, nextForm);
            formRAM.CurrentForm = nextForm;
        }

        private FormMain GetNextFormMain(FormMain currentForm)
        {
            //FormMain nextForm = listOfMains.Find(x => (x.number - currentForm.number) == 1);
            FormMain nextForm = listOfMains[0];
            listOfMains.RemoveAt(0);
            listOfMains.Add(nextForm);
            nextForm = listOfMains[0];
            if (nextForm.requestStream.Count == 0)
            {
                nextForm = GetNextFormMain(nextForm);
            }
            return nextForm;
        }

        private void reloadRequestStream(FormRAM fr, FormMain fm)
        {
            fr.requestStream = fm.requestStream;
        }

        private void FormRAM_SimulationDone(FormRAM formRam, EventArgs e)
        {
            //listOfMains = listOfMains.OrderBy(formMain => formMain.number).ToList();
            listOfMains.Sort((x, y) => x.number.CompareTo(y.number));
            foreach (FormMain fm in listOfMains)
            {
                Console.WriteLine(fm.number + " " + fm.pageErrorCount + " ");
            }
        }
    }
}
