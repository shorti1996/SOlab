namespace SO03
{
    partial class FormMain
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
            this.buttonGenerateRequests = new System.Windows.Forms.Button();
            this.labelVirtualMemSize = new System.Windows.Forms.Label();
            this.textBoxVirtualMemSize = new System.Windows.Forms.TextBox();
            this.textBoxPhysicalMemSize = new System.Windows.Forms.TextBox();
            this.labelPhysicalMemSize = new System.Windows.Forms.Label();
            this.textBoxRequestsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFIFO = new System.Windows.Forms.Button();
            this.buttonOPT = new System.Windows.Forms.Button();
            this.checkBoxLocalityOfReference = new System.Windows.Forms.CheckBox();
            this.textBoxLocalityOfReferenceChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLocalityOfReferenceParts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLocalityOfReferenceDensity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIFO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LRUapprox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRunMany = new System.Windows.Forms.Button();
            this.groupBoxMultipleSimulations = new System.Windows.Forms.GroupBox();
            this.textBoxFramesStep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFramesMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFramesMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxLocalityOfReference = new System.Windows.Forms.GroupBox();
            this.panelLocalityOfReference = new System.Windows.Forms.Panel();
            this.groupBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonLRUapprox = new System.Windows.Forms.Button();
            this.buttonLRU = new System.Windows.Forms.Button();
            this.buttonClearDataGridViewResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.groupBoxMultipleSimulations.SuspendLayout();
            this.groupBoxLocalityOfReference.SuspendLayout();
            this.panelLocalityOfReference.SuspendLayout();
            this.groupBoxGeneralSettings.SuspendLayout();
            this.groupBoxSimulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerateRequests
            // 
            this.buttonGenerateRequests.Location = new System.Drawing.Point(6, 115);
            this.buttonGenerateRequests.Name = "buttonGenerateRequests";
            this.buttonGenerateRequests.Size = new System.Drawing.Size(100, 44);
            this.buttonGenerateRequests.TabIndex = 0;
            this.buttonGenerateRequests.Text = "Generate requests";
            this.buttonGenerateRequests.UseVisualStyleBackColor = true;
            this.buttonGenerateRequests.Click += new System.EventHandler(this.buttonGenerateRequests_Click);
            // 
            // labelVirtualMemSize
            // 
            this.labelVirtualMemSize.AutoSize = true;
            this.labelVirtualMemSize.Location = new System.Drawing.Point(6, 63);
            this.labelVirtualMemSize.Name = "labelVirtualMemSize";
            this.labelVirtualMemSize.Size = new System.Drawing.Size(131, 17);
            this.labelVirtualMemSize.TabIndex = 1;
            this.labelVirtualMemSize.Text = "Virtual memory size";
            // 
            // textBoxVirtualMemSize
            // 
            this.textBoxVirtualMemSize.Location = new System.Drawing.Point(6, 83);
            this.textBoxVirtualMemSize.Name = "textBoxVirtualMemSize";
            this.textBoxVirtualMemSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxVirtualMemSize.TabIndex = 2;
            this.textBoxVirtualMemSize.Text = "10";
            // 
            // textBoxPhysicalMemSize
            // 
            this.textBoxPhysicalMemSize.Location = new System.Drawing.Point(143, 83);
            this.textBoxPhysicalMemSize.Name = "textBoxPhysicalMemSize";
            this.textBoxPhysicalMemSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhysicalMemSize.TabIndex = 4;
            this.textBoxPhysicalMemSize.Text = "5";
            // 
            // labelPhysicalMemSize
            // 
            this.labelPhysicalMemSize.AutoSize = true;
            this.labelPhysicalMemSize.Location = new System.Drawing.Point(143, 63);
            this.labelPhysicalMemSize.Name = "labelPhysicalMemSize";
            this.labelPhysicalMemSize.Size = new System.Drawing.Size(143, 17);
            this.labelPhysicalMemSize.TabIndex = 3;
            this.labelPhysicalMemSize.Text = "Physical memory size";
            // 
            // textBoxRequestsCount
            // 
            this.textBoxRequestsCount.Location = new System.Drawing.Point(6, 38);
            this.textBoxRequestsCount.Name = "textBoxRequestsCount";
            this.textBoxRequestsCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestsCount.TabIndex = 6;
            this.textBoxRequestsCount.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Requests Count";
            // 
            // buttonFIFO
            // 
            this.buttonFIFO.Location = new System.Drawing.Point(6, 21);
            this.buttonFIFO.Name = "buttonFIFO";
            this.buttonFIFO.Size = new System.Drawing.Size(100, 29);
            this.buttonFIFO.TabIndex = 7;
            this.buttonFIFO.Text = "FIFO";
            this.buttonFIFO.UseVisualStyleBackColor = true;
            this.buttonFIFO.Click += new System.EventHandler(this.buttonFIFO_Click);
            // 
            // buttonOPT
            // 
            this.buttonOPT.Location = new System.Drawing.Point(6, 56);
            this.buttonOPT.Name = "buttonOPT";
            this.buttonOPT.Size = new System.Drawing.Size(100, 29);
            this.buttonOPT.TabIndex = 10;
            this.buttonOPT.Text = "OPT";
            this.buttonOPT.UseVisualStyleBackColor = true;
            this.buttonOPT.Click += new System.EventHandler(this.buttonOPT_Click);
            // 
            // checkBoxLocalityOfReference
            // 
            this.checkBoxLocalityOfReference.AutoSize = true;
            this.checkBoxLocalityOfReference.Checked = true;
            this.checkBoxLocalityOfReference.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLocalityOfReference.Location = new System.Drawing.Point(6, 22);
            this.checkBoxLocalityOfReference.Name = "checkBoxLocalityOfReference";
            this.checkBoxLocalityOfReference.Size = new System.Drawing.Size(159, 21);
            this.checkBoxLocalityOfReference.TabIndex = 11;
            this.checkBoxLocalityOfReference.Text = "Locality of reference";
            this.checkBoxLocalityOfReference.UseVisualStyleBackColor = true;
            this.checkBoxLocalityOfReference.CheckedChanged += new System.EventHandler(this.checkBoxLocalityOfReference_CheckedChanged);
            // 
            // textBoxLocalityOfReferenceChance
            // 
            this.textBoxLocalityOfReferenceChance.Location = new System.Drawing.Point(6, 20);
            this.textBoxLocalityOfReferenceChance.Name = "textBoxLocalityOfReferenceChance";
            this.textBoxLocalityOfReferenceChance.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocalityOfReferenceChance.TabIndex = 13;
            this.textBoxLocalityOfReferenceChance.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Locality of reference Chance";
            // 
            // textBoxLocalityOfReferenceParts
            // 
            this.textBoxLocalityOfReferenceParts.Location = new System.Drawing.Point(6, 65);
            this.textBoxLocalityOfReferenceParts.Name = "textBoxLocalityOfReferenceParts";
            this.textBoxLocalityOfReferenceParts.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocalityOfReferenceParts.TabIndex = 15;
            this.textBoxLocalityOfReferenceParts.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Locality of reference Partitions";
            // 
            // textBoxLocalityOfReferenceDensity
            // 
            this.textBoxLocalityOfReferenceDensity.Location = new System.Drawing.Point(6, 110);
            this.textBoxLocalityOfReferenceDensity.Name = "textBoxLocalityOfReferenceDensity";
            this.textBoxLocalityOfReferenceDensity.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocalityOfReferenceDensity.TabIndex = 17;
            this.textBoxLocalityOfReferenceDensity.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Locality of reference Density";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Frames,
            this.Requests,
            this.FIFO,
            this.OPT,
            this.LRU,
            this.LRUapprox,
            this.Random});
            this.dataGridViewResults.Location = new System.Drawing.Point(9, 231);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(1214, 389);
            this.dataGridViewResults.TabIndex = 18;
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.Name = "Number";
            // 
            // Frames
            // 
            this.Frames.HeaderText = "Frames";
            this.Frames.Name = "Frames";
            // 
            // Requests
            // 
            this.Requests.HeaderText = "Requests";
            this.Requests.Name = "Requests";
            // 
            // FIFO
            // 
            this.FIFO.HeaderText = "FIFO";
            this.FIFO.Name = "FIFO";
            // 
            // OPT
            // 
            this.OPT.HeaderText = "OPT";
            this.OPT.Name = "OPT";
            // 
            // LRU
            // 
            this.LRU.HeaderText = "LRU";
            this.LRU.Name = "LRU";
            // 
            // LRUapprox
            // 
            this.LRUapprox.HeaderText = "LRUapprox";
            this.LRUapprox.Name = "LRUapprox";
            // 
            // Random
            // 
            this.Random.HeaderText = "Random";
            this.Random.Name = "Random";
            // 
            // buttonRunMany
            // 
            this.buttonRunMany.Location = new System.Drawing.Point(6, 178);
            this.buttonRunMany.Name = "buttonRunMany";
            this.buttonRunMany.Size = new System.Drawing.Size(100, 29);
            this.buttonRunMany.TabIndex = 19;
            this.buttonRunMany.Text = "Run";
            this.buttonRunMany.UseVisualStyleBackColor = true;
            this.buttonRunMany.Click += new System.EventHandler(this.buttonRunMany_Click);
            // 
            // groupBoxMultipleSimulations
            // 
            this.groupBoxMultipleSimulations.Controls.Add(this.textBoxFramesStep);
            this.groupBoxMultipleSimulations.Controls.Add(this.label7);
            this.groupBoxMultipleSimulations.Controls.Add(this.textBoxFramesMax);
            this.groupBoxMultipleSimulations.Controls.Add(this.label6);
            this.groupBoxMultipleSimulations.Controls.Add(this.textBoxFramesMin);
            this.groupBoxMultipleSimulations.Controls.Add(this.buttonRunMany);
            this.groupBoxMultipleSimulations.Controls.Add(this.label5);
            this.groupBoxMultipleSimulations.Location = new System.Drawing.Point(857, 12);
            this.groupBoxMultipleSimulations.Name = "groupBoxMultipleSimulations";
            this.groupBoxMultipleSimulations.Size = new System.Drawing.Size(366, 213);
            this.groupBoxMultipleSimulations.TabIndex = 20;
            this.groupBoxMultipleSimulations.TabStop = false;
            this.groupBoxMultipleSimulations.Text = "Multiple Simulations";
            // 
            // textBoxFramesStep
            // 
            this.textBoxFramesStep.Location = new System.Drawing.Point(137, 42);
            this.textBoxFramesStep.Name = "textBoxFramesStep";
            this.textBoxFramesStep.Size = new System.Drawing.Size(100, 22);
            this.textBoxFramesStep.TabIndex = 26;
            this.textBoxFramesStep.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Frames Step";
            // 
            // textBoxFramesMax
            // 
            this.textBoxFramesMax.Location = new System.Drawing.Point(256, 42);
            this.textBoxFramesMax.Name = "textBoxFramesMax";
            this.textBoxFramesMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxFramesMax.TabIndex = 24;
            this.textBoxFramesMax.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Frames Max";
            // 
            // textBoxFramesMin
            // 
            this.textBoxFramesMin.Location = new System.Drawing.Point(6, 42);
            this.textBoxFramesMin.Name = "textBoxFramesMin";
            this.textBoxFramesMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxFramesMin.TabIndex = 22;
            this.textBoxFramesMin.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Frames Min";
            // 
            // groupBoxLocalityOfReference
            // 
            this.groupBoxLocalityOfReference.Controls.Add(this.panelLocalityOfReference);
            this.groupBoxLocalityOfReference.Controls.Add(this.checkBoxLocalityOfReference);
            this.groupBoxLocalityOfReference.Location = new System.Drawing.Point(304, 12);
            this.groupBoxLocalityOfReference.Name = "groupBoxLocalityOfReference";
            this.groupBoxLocalityOfReference.Size = new System.Drawing.Size(272, 213);
            this.groupBoxLocalityOfReference.TabIndex = 21;
            this.groupBoxLocalityOfReference.TabStop = false;
            this.groupBoxLocalityOfReference.Text = "Locality Of Reference";
            // 
            // panelLocalityOfReference
            // 
            this.panelLocalityOfReference.Controls.Add(this.label3);
            this.panelLocalityOfReference.Controls.Add(this.textBoxLocalityOfReferenceParts);
            this.panelLocalityOfReference.Controls.Add(this.textBoxLocalityOfReferenceChance);
            this.panelLocalityOfReference.Controls.Add(this.label2);
            this.panelLocalityOfReference.Controls.Add(this.textBoxLocalityOfReferenceDensity);
            this.panelLocalityOfReference.Controls.Add(this.label4);
            this.panelLocalityOfReference.Location = new System.Drawing.Point(6, 49);
            this.panelLocalityOfReference.Name = "panelLocalityOfReference";
            this.panelLocalityOfReference.Size = new System.Drawing.Size(260, 158);
            this.panelLocalityOfReference.TabIndex = 22;
            // 
            // groupBoxGeneralSettings
            // 
            this.groupBoxGeneralSettings.Controls.Add(this.label1);
            this.groupBoxGeneralSettings.Controls.Add(this.buttonGenerateRequests);
            this.groupBoxGeneralSettings.Controls.Add(this.labelVirtualMemSize);
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxVirtualMemSize);
            this.groupBoxGeneralSettings.Controls.Add(this.labelPhysicalMemSize);
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxPhysicalMemSize);
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxRequestsCount);
            this.groupBoxGeneralSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGeneralSettings.Name = "groupBoxGeneralSettings";
            this.groupBoxGeneralSettings.Size = new System.Drawing.Size(286, 213);
            this.groupBoxGeneralSettings.TabIndex = 22;
            this.groupBoxGeneralSettings.TabStop = false;
            this.groupBoxGeneralSettings.Text = "General Settings";
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Controls.Add(this.buttonRandom);
            this.groupBoxSimulation.Controls.Add(this.buttonLRUapprox);
            this.groupBoxSimulation.Controls.Add(this.buttonLRU);
            this.groupBoxSimulation.Controls.Add(this.buttonFIFO);
            this.groupBoxSimulation.Controls.Add(this.buttonOPT);
            this.groupBoxSimulation.Location = new System.Drawing.Point(582, 12);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(277, 213);
            this.groupBoxSimulation.TabIndex = 23;
            this.groupBoxSimulation.TabStop = false;
            this.groupBoxSimulation.Text = "Simulation";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRandom.Location = new System.Drawing.Point(6, 161);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(100, 29);
            this.buttonRandom.TabIndex = 13;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonLRUapprox
            // 
            this.buttonLRUapprox.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLRUapprox.Location = new System.Drawing.Point(6, 126);
            this.buttonLRUapprox.Name = "buttonLRUapprox";
            this.buttonLRUapprox.Size = new System.Drawing.Size(100, 29);
            this.buttonLRUapprox.TabIndex = 12;
            this.buttonLRUapprox.Text = "LRUapprox";
            this.buttonLRUapprox.UseVisualStyleBackColor = true;
            this.buttonLRUapprox.Click += new System.EventHandler(this.buttonLRUapprox_Click);
            // 
            // buttonLRU
            // 
            this.buttonLRU.Location = new System.Drawing.Point(6, 91);
            this.buttonLRU.Name = "buttonLRU";
            this.buttonLRU.Size = new System.Drawing.Size(100, 29);
            this.buttonLRU.TabIndex = 11;
            this.buttonLRU.Text = "LRU";
            this.buttonLRU.UseVisualStyleBackColor = true;
            this.buttonLRU.Click += new System.EventHandler(this.buttonLRU_Click);
            // 
            // buttonClearDataGridViewResults
            // 
            this.buttonClearDataGridViewResults.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonClearDataGridViewResults.Location = new System.Drawing.Point(1123, 626);
            this.buttonClearDataGridViewResults.Name = "buttonClearDataGridViewResults";
            this.buttonClearDataGridViewResults.Size = new System.Drawing.Size(100, 29);
            this.buttonClearDataGridViewResults.TabIndex = 14;
            this.buttonClearDataGridViewResults.Text = "Clear";
            this.buttonClearDataGridViewResults.UseVisualStyleBackColor = true;
            this.buttonClearDataGridViewResults.Click += new System.EventHandler(this.buttonClearDataGridViewResults_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 665);
            this.Controls.Add(this.buttonClearDataGridViewResults);
            this.Controls.Add(this.groupBoxSimulation);
            this.Controls.Add(this.groupBoxGeneralSettings);
            this.Controls.Add(this.groupBoxLocalityOfReference);
            this.Controls.Add(this.groupBoxMultipleSimulations);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "FormMain";
            this.Text = "q";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.groupBoxMultipleSimulations.ResumeLayout(false);
            this.groupBoxMultipleSimulations.PerformLayout();
            this.groupBoxLocalityOfReference.ResumeLayout(false);
            this.groupBoxLocalityOfReference.PerformLayout();
            this.panelLocalityOfReference.ResumeLayout(false);
            this.panelLocalityOfReference.PerformLayout();
            this.groupBoxGeneralSettings.ResumeLayout(false);
            this.groupBoxGeneralSettings.PerformLayout();
            this.groupBoxSimulation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateRequests;
        private System.Windows.Forms.Label labelVirtualMemSize;
        private System.Windows.Forms.TextBox textBoxVirtualMemSize;
        private System.Windows.Forms.TextBox textBoxPhysicalMemSize;
        private System.Windows.Forms.Label labelPhysicalMemSize;
        private System.Windows.Forms.TextBox textBoxRequestsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFIFO;
        private System.Windows.Forms.Button buttonOPT;
        private System.Windows.Forms.CheckBox checkBoxLocalityOfReference;
        private System.Windows.Forms.TextBox textBoxLocalityOfReferenceChance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLocalityOfReferenceParts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLocalityOfReferenceDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonRunMany;
        private System.Windows.Forms.GroupBox groupBoxMultipleSimulations;
        private System.Windows.Forms.TextBox textBoxFramesStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFramesMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFramesMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxLocalityOfReference;
        private System.Windows.Forms.Panel panelLocalityOfReference;
        private System.Windows.Forms.GroupBox groupBoxGeneralSettings;
        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.Button buttonLRU;
        private System.Windows.Forms.Button buttonLRUapprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requests;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIFO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LRU;
        private System.Windows.Forms.DataGridViewTextBoxColumn LRUapprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonClearDataGridViewResults;
    }
}

