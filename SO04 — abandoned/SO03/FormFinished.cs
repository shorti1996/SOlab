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
    public partial class FormFinished : Form
    {
        public FormFinished()
        {
            InitializeComponent();

            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 1)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
        }
    }
}
