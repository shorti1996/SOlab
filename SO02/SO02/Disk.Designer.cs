namespace SO02
{
    partial class Disk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult = new System.Windows.Forms.Label();
            this.richTextBoxRejectedRequests = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDoneRequests = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // chartResult
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartResult.Legends.Add(legend3);
            this.chartResult.Location = new System.Drawing.Point(12, 12);
            this.chartResult.Name = "chartResult";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chartResult.Series.Add(series5);
            this.chartResult.Series.Add(series6);
            this.chartResult.Size = new System.Drawing.Size(750, 478);
            this.chartResult.TabIndex = 0;
            this.chartResult.Text = "chart1";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 493);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(16, 17);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "0";
            // 
            // richTextBoxRejectedRequests
            // 
            this.richTextBoxRejectedRequests.Location = new System.Drawing.Point(769, 13);
            this.richTextBoxRejectedRequests.Name = "richTextBoxRejectedRequests";
            this.richTextBoxRejectedRequests.Size = new System.Drawing.Size(132, 477);
            this.richTextBoxRejectedRequests.TabIndex = 2;
            this.richTextBoxRejectedRequests.Text = "Rejected Requests:";
            // 
            // richTextBoxDoneRequests
            // 
            this.richTextBoxDoneRequests.Location = new System.Drawing.Point(907, 13);
            this.richTextBoxDoneRequests.Name = "richTextBoxDoneRequests";
            this.richTextBoxDoneRequests.Size = new System.Drawing.Size(132, 477);
            this.richTextBoxDoneRequests.TabIndex = 3;
            this.richTextBoxDoneRequests.Text = "Done Requests:";
            // 
            // Disk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 533);
            this.Controls.Add(this.richTextBoxDoneRequests);
            this.Controls.Add(this.richTextBoxRejectedRequests);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.chartResult);
            this.Name = "Disk";
            this.Text = "Disk";
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBoxRejectedRequests;
        private System.Windows.Forms.RichTextBox richTextBoxDoneRequests;
    }
}