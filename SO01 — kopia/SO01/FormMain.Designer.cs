namespace SO01
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
            this.components = new System.ComponentModel.Container();
            this.buttonFCFS = new System.Windows.Forms.Button();
            this.generateProcesses = new System.Windows.Forms.Button();
            this.textBoxProcessCount = new System.Windows.Forms.TextBox();
            this.textBoxLifeTimeMin = new System.Windows.Forms.TextBox();
            this.textBoxLifeTimeMax = new System.Windows.Forms.TextBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewProcess = new System.Windows.Forms.DataGridView();
            this.buttonSJF = new System.Windows.Forms.Button();
            this.buttonReloadProcesses = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxGenerateNew = new System.Windows.Forms.CheckBox();
            this.textBoxTimeStartMin = new System.Windows.Forms.TextBox();
            this.textBoxTimeStartMax = new System.Windows.Forms.TextBox();
            this.labelTimePassed = new System.Windows.Forms.Label();
            this.labelTimePassedValue = new System.Windows.Forms.Label();
            this.buttonSJFP = new System.Windows.Forms.Button();
            this.buttonAddCustom = new System.Windows.Forms.Button();
            this.labelProcessCount = new System.Windows.Forms.Label();
            this.labelLifeTimeMin = new System.Windows.Forms.Label();
            this.labelLifeTimeMax = new System.Windows.Forms.Label();
            this.labelTimeStartMin = new System.Windows.Forms.Label();
            this.labelTimeStartMax = new System.Windows.Forms.Label();
            this.buttonCloneList = new System.Windows.Forms.Button();
            this.buttonRR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearProcesses = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBatchSimulation = new System.Windows.Forms.Button();
            this.labelTimerMainTick = new System.Windows.Forms.Label();
            this.textBoxTimerMainTick = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFCFS
            // 
            this.buttonFCFS.Location = new System.Drawing.Point(6, 216);
            this.buttonFCFS.Name = "buttonFCFS";
            this.buttonFCFS.Size = new System.Drawing.Size(88, 38);
            this.buttonFCFS.TabIndex = 0;
            this.buttonFCFS.Text = "FCFS";
            this.buttonFCFS.UseVisualStyleBackColor = true;
            this.buttonFCFS.Click += new System.EventHandler(this.buttonFCFS_Click);
            // 
            // generateProcesses
            // 
            this.generateProcesses.Location = new System.Drawing.Point(6, 101);
            this.generateProcesses.Name = "generateProcesses";
            this.generateProcesses.Size = new System.Drawing.Size(191, 38);
            this.generateProcesses.TabIndex = 1;
            this.generateProcesses.Text = "Generate Processes";
            this.generateProcesses.UseVisualStyleBackColor = true;
            this.generateProcesses.Click += new System.EventHandler(this.generateProcesses_Click);
            // 
            // textBoxProcessCount
            // 
            this.textBoxProcessCount.Location = new System.Drawing.Point(6, 20);
            this.textBoxProcessCount.Name = "textBoxProcessCount";
            this.textBoxProcessCount.Size = new System.Drawing.Size(46, 22);
            this.textBoxProcessCount.TabIndex = 2;
            this.textBoxProcessCount.Text = "10";
            // 
            // textBoxLifeTimeMin
            // 
            this.textBoxLifeTimeMin.Location = new System.Drawing.Point(58, 20);
            this.textBoxLifeTimeMin.Name = "textBoxLifeTimeMin";
            this.textBoxLifeTimeMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLifeTimeMin.TabIndex = 3;
            this.textBoxLifeTimeMin.Text = "1000";
            // 
            // textBoxLifeTimeMax
            // 
            this.textBoxLifeTimeMax.Location = new System.Drawing.Point(164, 20);
            this.textBoxLifeTimeMax.Name = "textBoxLifeTimeMax";
            this.textBoxLifeTimeMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxLifeTimeMax.TabIndex = 4;
            this.textBoxLifeTimeMax.Text = "5000";
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcess.Location = new System.Drawing.Point(426, 12);
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.RowTemplate.Height = 24;
            this.dataGridViewProcess.Size = new System.Drawing.Size(646, 422);
            this.dataGridViewProcess.TabIndex = 5;
            // 
            // buttonSJF
            // 
            this.buttonSJF.Location = new System.Drawing.Point(100, 216);
            this.buttonSJF.Name = "buttonSJF";
            this.buttonSJF.Size = new System.Drawing.Size(88, 38);
            this.buttonSJF.TabIndex = 6;
            this.buttonSJF.Text = "SJF";
            this.buttonSJF.UseVisualStyleBackColor = true;
            this.buttonSJF.Click += new System.EventHandler(this.buttonSJF_Click);
            // 
            // buttonReloadProcesses
            // 
            this.buttonReloadProcesses.Location = new System.Drawing.Point(6, 145);
            this.buttonReloadProcesses.Name = "buttonReloadProcesses";
            this.buttonReloadProcesses.Size = new System.Drawing.Size(191, 38);
            this.buttonReloadProcesses.TabIndex = 7;
            this.buttonReloadProcesses.Text = "Reload Processes";
            this.buttonReloadProcesses.UseVisualStyleBackColor = true;
            this.buttonReloadProcesses.Click += new System.EventHandler(this.buttonReloadProcesses_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(6, 280);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(88, 38);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkBoxGenerateNew
            // 
            this.checkBoxGenerateNew.AutoSize = true;
            this.checkBoxGenerateNew.Location = new System.Drawing.Point(6, 189);
            this.checkBoxGenerateNew.Name = "checkBoxGenerateNew";
            this.checkBoxGenerateNew.Size = new System.Drawing.Size(240, 21);
            this.checkBoxGenerateNew.TabIndex = 9;
            this.checkBoxGenerateNew.Text = "Generate new random processes";
            this.checkBoxGenerateNew.UseVisualStyleBackColor = true;
            // 
            // textBoxTimeStartMin
            // 
            this.textBoxTimeStartMin.Location = new System.Drawing.Point(58, 73);
            this.textBoxTimeStartMin.Name = "textBoxTimeStartMin";
            this.textBoxTimeStartMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeStartMin.TabIndex = 10;
            this.textBoxTimeStartMin.Text = "100";
            // 
            // textBoxTimeStartMax
            // 
            this.textBoxTimeStartMax.Location = new System.Drawing.Point(164, 73);
            this.textBoxTimeStartMax.Name = "textBoxTimeStartMax";
            this.textBoxTimeStartMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeStartMax.TabIndex = 11;
            this.textBoxTimeStartMax.Text = "10000";
            // 
            // labelTimePassed
            // 
            this.labelTimePassed.AutoSize = true;
            this.labelTimePassed.Location = new System.Drawing.Point(191, 301);
            this.labelTimePassed.Name = "labelTimePassed";
            this.labelTimePassed.Size = new System.Drawing.Size(94, 17);
            this.labelTimePassed.TabIndex = 12;
            this.labelTimePassed.Text = "Time Passed:";
            this.labelTimePassed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelTimePassed_MouseDoubleClick);
            // 
            // labelTimePassedValue
            // 
            this.labelTimePassedValue.AutoSize = true;
            this.labelTimePassedValue.Location = new System.Drawing.Point(291, 301);
            this.labelTimePassedValue.Name = "labelTimePassedValue";
            this.labelTimePassedValue.Size = new System.Drawing.Size(16, 17);
            this.labelTimePassedValue.TabIndex = 13;
            this.labelTimePassedValue.Text = "0";
            // 
            // buttonSJFP
            // 
            this.buttonSJFP.Location = new System.Drawing.Point(194, 216);
            this.buttonSJFP.Name = "buttonSJFP";
            this.buttonSJFP.Size = new System.Drawing.Size(88, 38);
            this.buttonSJFP.TabIndex = 14;
            this.buttonSJFP.Text = "SJFP";
            this.buttonSJFP.UseVisualStyleBackColor = true;
            this.buttonSJFP.Click += new System.EventHandler(this.buttonSJFP_Click);
            // 
            // buttonAddCustom
            // 
            this.buttonAddCustom.Location = new System.Drawing.Point(203, 101);
            this.buttonAddCustom.Name = "buttonAddCustom";
            this.buttonAddCustom.Size = new System.Drawing.Size(96, 38);
            this.buttonAddCustom.TabIndex = 15;
            this.buttonAddCustom.Text = "Add Custom";
            this.buttonAddCustom.UseVisualStyleBackColor = true;
            this.buttonAddCustom.Click += new System.EventHandler(this.buttonAddCustom_Click);
            // 
            // labelProcessCount
            // 
            this.labelProcessCount.AutoSize = true;
            this.labelProcessCount.Location = new System.Drawing.Point(3, 0);
            this.labelProcessCount.Name = "labelProcessCount";
            this.labelProcessCount.Size = new System.Drawing.Size(45, 17);
            this.labelProcessCount.TabIndex = 16;
            this.labelProcessCount.Text = "Count";
            // 
            // labelLifeTimeMin
            // 
            this.labelLifeTimeMin.AutoSize = true;
            this.labelLifeTimeMin.Location = new System.Drawing.Point(54, 0);
            this.labelLifeTimeMin.Name = "labelLifeTimeMin";
            this.labelLifeTimeMin.Size = new System.Drawing.Size(88, 17);
            this.labelLifeTimeMin.TabIndex = 17;
            this.labelLifeTimeMin.Text = "LifeTime Min";
            // 
            // labelLifeTimeMax
            // 
            this.labelLifeTimeMax.AutoSize = true;
            this.labelLifeTimeMax.Location = new System.Drawing.Point(161, 0);
            this.labelLifeTimeMax.Name = "labelLifeTimeMax";
            this.labelLifeTimeMax.Size = new System.Drawing.Size(91, 17);
            this.labelLifeTimeMax.TabIndex = 18;
            this.labelLifeTimeMax.Text = "LifeTime Max";
            // 
            // labelTimeStartMin
            // 
            this.labelTimeStartMin.AutoSize = true;
            this.labelTimeStartMin.Location = new System.Drawing.Point(55, 53);
            this.labelTimeStartMin.Name = "labelTimeStartMin";
            this.labelTimeStartMin.Size = new System.Drawing.Size(95, 17);
            this.labelTimeStartMin.TabIndex = 19;
            this.labelTimeStartMin.Text = "TimeStart Min";
            // 
            // labelTimeStartMax
            // 
            this.labelTimeStartMax.AutoSize = true;
            this.labelTimeStartMax.Location = new System.Drawing.Point(161, 53);
            this.labelTimeStartMax.Name = "labelTimeStartMax";
            this.labelTimeStartMax.Size = new System.Drawing.Size(95, 17);
            this.labelTimeStartMax.TabIndex = 20;
            this.labelTimeStartMax.Text = "TimeStart Min";
            // 
            // buttonCloneList
            // 
            this.buttonCloneList.Location = new System.Drawing.Point(203, 145);
            this.buttonCloneList.Name = "buttonCloneList";
            this.buttonCloneList.Size = new System.Drawing.Size(96, 38);
            this.buttonCloneList.TabIndex = 21;
            this.buttonCloneList.Text = "Clone List";
            this.buttonCloneList.UseVisualStyleBackColor = true;
            this.buttonCloneList.Click += new System.EventHandler(this.buttonCloneList_Click);
            // 
            // buttonRR
            // 
            this.buttonRR.Location = new System.Drawing.Point(288, 216);
            this.buttonRR.Name = "buttonRR";
            this.buttonRR.Size = new System.Drawing.Size(88, 38);
            this.buttonRR.TabIndex = 22;
            this.buttonRR.Text = "RR";
            this.buttonRR.UseVisualStyleBackColor = true;
            this.buttonRR.Click += new System.EventHandler(this.buttonRR_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTimerMainTick);
            this.panel1.Controls.Add(this.textBoxTimerMainTick);
            this.panel1.Controls.Add(this.buttonClearProcesses);
            this.panel1.Controls.Add(this.labelProcessCount);
            this.panel1.Controls.Add(this.buttonRR);
            this.panel1.Controls.Add(this.buttonFCFS);
            this.panel1.Controls.Add(this.buttonCloneList);
            this.panel1.Controls.Add(this.generateProcesses);
            this.panel1.Controls.Add(this.labelTimeStartMax);
            this.panel1.Controls.Add(this.textBoxProcessCount);
            this.panel1.Controls.Add(this.labelTimeStartMin);
            this.panel1.Controls.Add(this.textBoxLifeTimeMin);
            this.panel1.Controls.Add(this.labelLifeTimeMax);
            this.panel1.Controls.Add(this.textBoxLifeTimeMax);
            this.panel1.Controls.Add(this.labelLifeTimeMin);
            this.panel1.Controls.Add(this.buttonSJF);
            this.panel1.Controls.Add(this.buttonReloadProcesses);
            this.panel1.Controls.Add(this.buttonAddCustom);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonSJFP);
            this.panel1.Controls.Add(this.checkBoxGenerateNew);
            this.panel1.Controls.Add(this.labelTimePassedValue);
            this.panel1.Controls.Add(this.textBoxTimeStartMin);
            this.panel1.Controls.Add(this.labelTimePassed);
            this.panel1.Controls.Add(this.textBoxTimeStartMax);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 333);
            this.panel1.TabIndex = 23;
            // 
            // buttonClearProcesses
            // 
            this.buttonClearProcesses.Location = new System.Drawing.Point(305, 145);
            this.buttonClearProcesses.Name = "buttonClearProcesses";
            this.buttonClearProcesses.Size = new System.Drawing.Size(96, 38);
            this.buttonClearProcesses.TabIndex = 23;
            this.buttonClearProcesses.Text = "Clear List";
            this.buttonClearProcesses.UseVisualStyleBackColor = true;
            this.buttonClearProcesses.Click += new System.EventHandler(this.buttonClearProcesses_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.buttonBatchSimulation);
            this.panel2.Location = new System.Drawing.Point(12, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 137);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Count";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "20";
            // 
            // buttonBatchSimulation
            // 
            this.buttonBatchSimulation.Location = new System.Drawing.Point(6, 91);
            this.buttonBatchSimulation.Name = "buttonBatchSimulation";
            this.buttonBatchSimulation.Size = new System.Drawing.Size(88, 38);
            this.buttonBatchSimulation.TabIndex = 23;
            this.buttonBatchSimulation.Text = "Batch";
            this.buttonBatchSimulation.UseVisualStyleBackColor = true;
            this.buttonBatchSimulation.Click += new System.EventHandler(this.buttonBatchSimulation_Click);
            // 
            // labelTimerMainTick
            // 
            this.labelTimerMainTick.AutoSize = true;
            this.labelTimerMainTick.Location = new System.Drawing.Point(331, 0);
            this.labelTimerMainTick.Name = "labelTimerMainTick";
            this.labelTimerMainTick.Size = new System.Drawing.Size(74, 17);
            this.labelTimerMainTick.TabIndex = 25;
            this.labelTimerMainTick.Text = "Timer Tick";
            // 
            // textBoxTimerMainTick
            // 
            this.textBoxTimerMainTick.Location = new System.Drawing.Point(334, 20);
            this.textBoxTimerMainTick.Name = "textBoxTimerMainTick";
            this.textBoxTimerMainTick.Size = new System.Drawing.Size(46, 22);
            this.textBoxTimerMainTick.TabIndex = 24;
            this.textBoxTimerMainTick.Text = "10";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewProcess);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFCFS;
        private System.Windows.Forms.Button generateProcesses;
        private System.Windows.Forms.TextBox textBoxProcessCount;
        private System.Windows.Forms.TextBox textBoxLifeTimeMin;
        private System.Windows.Forms.TextBox textBoxLifeTimeMax;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.DataGridView dataGridViewProcess;
        private System.Windows.Forms.Button buttonSJF;
        private System.Windows.Forms.Button buttonReloadProcesses;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxGenerateNew;
        private System.Windows.Forms.TextBox textBoxTimeStartMin;
        private System.Windows.Forms.TextBox textBoxTimeStartMax;
        private System.Windows.Forms.Label labelTimePassed;
        private System.Windows.Forms.Label labelTimePassedValue;
        private System.Windows.Forms.Button buttonSJFP;
        private System.Windows.Forms.Button buttonAddCustom;
        private System.Windows.Forms.Label labelProcessCount;
        private System.Windows.Forms.Label labelLifeTimeMin;
        private System.Windows.Forms.Label labelLifeTimeMax;
        private System.Windows.Forms.Label labelTimeStartMin;
        private System.Windows.Forms.Label labelTimeStartMax;
        private System.Windows.Forms.Button buttonCloneList;
        private System.Windows.Forms.Button buttonRR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBatchSimulation;
        private System.Windows.Forms.Button buttonClearProcesses;
        private System.Windows.Forms.Label labelTimerMainTick;
        private System.Windows.Forms.TextBox textBoxTimerMainTick;
    }
}