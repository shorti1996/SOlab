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
    public partial class FormChart : Form
    {
        private DataGridView dataGridViewResults;

        public FormChart()
        {
            InitializeComponent();
        }

        public FormChart(DataGridView dataGridViewResults) : this()
        {
            this.dataGridViewResults = dataGridViewResults;
            //chartResults.Series.Clear();

            List<string> names = new List<string>();
            List<int> values = new List<int>();

            for (int i = 3; i < dataGridViewResults.Columns.Count; i++)
            {
                names.Add(dataGridViewResults.Columns[i].Name);
                values.Add(int.Parse(dataGridViewResults.Rows[dataGridViewResults.Rows.Count - 2].Cells[i].Value.ToString()));
            }
            chartResults.Series[0].Points.DataBindXY( names, values);
            chartResults.Series[0].IsValueShownAsLabel = true;

            //int j = 0;
            //for (int i = 3; i < dataGridViewResults.Columns.Count; i++)
            //{
            //    chartResults.Series.Add(dataGridViewResults.Columns[i].Name);
            //    chartResults.Series[0].Points.Add(int.Parse(dataGridViewResults.Rows[dataGridViewResults.Rows.Count - 2].Cells[i].Value.ToString()));
            //    chartResults.Series[0].Label = dataGridViewResults.Columns[i].Name;
            //    j++;
            //}
        }
    }
}
