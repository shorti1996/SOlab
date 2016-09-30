using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO04
{
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

    public partial class FormManager : Form
    {
        List<FormMain> listOfMains = new List<FormMain>();
        List<FormMain> listOfMainsCopy;
        public FormManager()
        {
            InitializeComponent();

            List<InitializationObject> init = new List<InitializationObject>();
            init.Add(new InitializationObject("requestCount", 500));
            init.Add(new InitializationObject("virtualMemorySize", 100));
            init.Add(new InitializationObject("physicalMemorySize", 10));
            init.Add(new InitializationObject("localityOfReferenceChance", 70));
            init.Add(new InitializationObject("endOfStreamChance", 30));

            for (int i = 0; i < 10; i++)
            {
                FormMain fm = new FormMain(init, i);
                listOfMains.Add(fm);
                //fm.Show();
                fm.GenerateRequests();
            }
            foreach (FormMain fm in listOfMains)
            {
                fm.InitializeSimulation();
                fm.endOfStream += FormMain_endOfStream;
                fm.SimulationDone += FormMain_SimulationDone;
            }
            listOfMainsCopy = new List<FormMain>(listOfMains);

            PerformSimulation(listOfMains[0]);
        }

        private void FormMain_SimulationDone(FormMain formMain, EventArgs e)
        {
            FormMain formMainDone = formMain;
            int index = listOfMains.FindIndex(x => x.number == formMainDone.number);
            listOfMains.RemoveAt(index);

            if (listOfMains.Count > 0)
            {
                FormMain nextForm = GetNextFormMain(formMainDone);
                UpdateRAMSize();
                nextForm.Resume();
            }
        }

        private void FormMain_endOfStream(FormMain formMain, EventArgs e)
        {
            FormMain nextForm = GetNextFormMain(formMain);
            UpdateRAMSize();
            nextForm.Resume();
        }

        public void PerformSimulation(FormMain firstMain)
        {
            if (firstMain.requestStream == null)
            {
                return;
            }
            UpdateRAMSize();
            firstMain.Resume();
        }

        private void UpdateRAMSize()
        {
            //throw new NotImplementedException();
        }

        private FormMain GetNextFormMain(FormMain currentForm)
        {
            FormMain nextForm = listOfMains[0];
            listOfMains.RemoveAt(0);
            listOfMains.Add(nextForm);
            nextForm = listOfMains[0];
            if (nextForm.requestStream.Count == 0)
            {
                if (listOfMains.Count == 0)
                {
                    Console.WriteLine("DONE");
                    return null;
                }
                nextForm = GetNextFormMain(nextForm);
            }
            return nextForm;
        }

        private void reloadRequestStream(FormRAM fr, FormMain fm)
        {
            fr.requestStream = fm.requestStream;
        }


    }
}

