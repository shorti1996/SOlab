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
    public partial class FormAddCustom : Form
    {
        List<Process> list;
        FormMain formMain;
        public FormAddCustom()
        {
            InitializeComponent();
        }
        public FormAddCustom(FormMain form, List<Process> list)
        {
            InitializeComponent();
            this.list = list;
            this.formMain = form;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            int lifeTime, timeStart;
            int number = 0;
            Int32.TryParse(textBoxLifeTime.Text, out lifeTime);
            Int32.TryParse(textBoxTimeStart.Text, out timeStart);
            Process process = new Process(guid, lifeTime, number, timeStart);
            try
            {
                list.Add(process);
            }
            catch (/*NullReferenceException*/Exception)
            {
                list = new List<Process>();
                list.Add(process);
            }
            process.number = list.Count;
        }
    }
}
