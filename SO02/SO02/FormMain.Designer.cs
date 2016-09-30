namespace SO02
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
            this.textBoxRequestCount = new System.Windows.Forms.TextBox();
            this.labelRequestCount = new System.Windows.Forms.Label();
            this.labelDiskSize = new System.Windows.Forms.Label();
            this.textBoxDiskSize = new System.Windows.Forms.TextBox();
            this.buttonCreateDisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRequestStartMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRequestRangeMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRequestTimeEnterMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRequestsRealTime = new System.Windows.Forms.TextBox();
            this.buttonCopyList = new System.Windows.Forms.Button();
            this.buttonCreateDiskSSTF = new System.Windows.Forms.Button();
            this.buttonAddCustomRequest = new System.Windows.Forms.Button();
            this.button1CreateDiskSCAN = new System.Windows.Forms.Button();
            this.buttonCreateDiskCSCAN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRequestDeadline = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReqestDeadlinePercent = new System.Windows.Forms.TextBox();
            this.buttonCreateDiskFCFS_FDSCAN = new System.Windows.Forms.Button();
            this.buttonCreateDiskSSTF_FDSCAN = new System.Windows.Forms.Button();
            this.buttonCreateDiskSCAN_FDSCAN = new System.Windows.Forms.Button();
            this.buttonCreateDiskCSCAN_FDSCAN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerateRequests
            // 
            this.buttonGenerateRequests.Location = new System.Drawing.Point(12, 88);
            this.buttonGenerateRequests.Name = "buttonGenerateRequests";
            this.buttonGenerateRequests.Size = new System.Drawing.Size(139, 34);
            this.buttonGenerateRequests.TabIndex = 0;
            this.buttonGenerateRequests.Text = "Generate requests";
            this.buttonGenerateRequests.UseVisualStyleBackColor = true;
            this.buttonGenerateRequests.Click += new System.EventHandler(this.buttonGenerateRequests_Click);
            // 
            // textBoxRequestCount
            // 
            this.textBoxRequestCount.Location = new System.Drawing.Point(12, 40);
            this.textBoxRequestCount.Name = "textBoxRequestCount";
            this.textBoxRequestCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestCount.TabIndex = 1;
            this.textBoxRequestCount.Text = "10";
            // 
            // labelRequestCount
            // 
            this.labelRequestCount.AutoSize = true;
            this.labelRequestCount.Location = new System.Drawing.Point(9, 20);
            this.labelRequestCount.Name = "labelRequestCount";
            this.labelRequestCount.Size = new System.Drawing.Size(100, 17);
            this.labelRequestCount.TabIndex = 2;
            this.labelRequestCount.Text = "Request count";
            // 
            // labelDiskSize
            // 
            this.labelDiskSize.AutoSize = true;
            this.labelDiskSize.Location = new System.Drawing.Point(194, 20);
            this.labelDiskSize.Name = "labelDiskSize";
            this.labelDiskSize.Size = new System.Drawing.Size(64, 17);
            this.labelDiskSize.TabIndex = 4;
            this.labelDiskSize.Text = "Disk size";
            // 
            // textBoxDiskSize
            // 
            this.textBoxDiskSize.Location = new System.Drawing.Point(197, 40);
            this.textBoxDiskSize.Name = "textBoxDiskSize";
            this.textBoxDiskSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiskSize.TabIndex = 3;
            this.textBoxDiskSize.Text = "100";
            // 
            // buttonCreateDisk
            // 
            this.buttonCreateDisk.Location = new System.Drawing.Point(197, 88);
            this.buttonCreateDisk.Name = "buttonCreateDisk";
            this.buttonCreateDisk.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDisk.TabIndex = 5;
            this.buttonCreateDisk.Text = "Create disk FCFS";
            this.buttonCreateDisk.UseVisualStyleBackColor = true;
            this.buttonCreateDisk.Click += new System.EventHandler(this.buttonCreateDisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Request Start Min";
            // 
            // textBoxRequestStartMin
            // 
            this.textBoxRequestStartMin.Location = new System.Drawing.Point(382, 40);
            this.textBoxRequestStartMin.Name = "textBoxRequestStartMin";
            this.textBoxRequestStartMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestStartMin.TabIndex = 6;
            this.textBoxRequestStartMin.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Request Range Max";
            // 
            // textBoxRequestRangeMax
            // 
            this.textBoxRequestRangeMax.Location = new System.Drawing.Point(512, 40);
            this.textBoxRequestRangeMax.Name = "textBoxRequestRangeMax";
            this.textBoxRequestRangeMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestRangeMax.TabIndex = 8;
            this.textBoxRequestRangeMax.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Request TimeEnter Max";
            // 
            // textBoxRequestTimeEnterMax
            // 
            this.textBoxRequestTimeEnterMax.Location = new System.Drawing.Point(654, 40);
            this.textBoxRequestTimeEnterMax.Name = "textBoxRequestTimeEnterMax";
            this.textBoxRequestTimeEnterMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestTimeEnterMax.TabIndex = 10;
            this.textBoxRequestTimeEnterMax.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Request % RealTime";
            // 
            // textBoxRequestsRealTime
            // 
            this.textBoxRequestsRealTime.Location = new System.Drawing.Point(819, 40);
            this.textBoxRequestsRealTime.Name = "textBoxRequestsRealTime";
            this.textBoxRequestsRealTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestsRealTime.TabIndex = 12;
            this.textBoxRequestsRealTime.Text = "30";
            // 
            // buttonCopyList
            // 
            this.buttonCopyList.Location = new System.Drawing.Point(12, 128);
            this.buttonCopyList.Name = "buttonCopyList";
            this.buttonCopyList.Size = new System.Drawing.Size(100, 34);
            this.buttonCopyList.TabIndex = 14;
            this.buttonCopyList.Text = "Copy List";
            this.buttonCopyList.UseVisualStyleBackColor = true;
            this.buttonCopyList.Click += new System.EventHandler(this.buttonCopyList_Click);
            // 
            // buttonCreateDiskSSTF
            // 
            this.buttonCreateDiskSSTF.Location = new System.Drawing.Point(197, 128);
            this.buttonCreateDiskSSTF.Name = "buttonCreateDiskSSTF";
            this.buttonCreateDiskSSTF.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDiskSSTF.TabIndex = 15;
            this.buttonCreateDiskSSTF.Text = "Create disk SSTF";
            this.buttonCreateDiskSSTF.UseVisualStyleBackColor = true;
            this.buttonCreateDiskSSTF.Click += new System.EventHandler(this.buttonCreateDiskSSTF_Click);
            // 
            // buttonAddCustomRequest
            // 
            this.buttonAddCustomRequest.Location = new System.Drawing.Point(12, 168);
            this.buttonAddCustomRequest.Name = "buttonAddCustomRequest";
            this.buttonAddCustomRequest.Size = new System.Drawing.Size(171, 34);
            this.buttonAddCustomRequest.TabIndex = 16;
            this.buttonAddCustomRequest.Text = "Add custom request";
            this.buttonAddCustomRequest.UseVisualStyleBackColor = true;
            this.buttonAddCustomRequest.Click += new System.EventHandler(this.buttonAddCustomRequest_Click);
            // 
            // button1CreateDiskSCAN
            // 
            this.button1CreateDiskSCAN.Location = new System.Drawing.Point(197, 168);
            this.button1CreateDiskSCAN.Name = "button1CreateDiskSCAN";
            this.button1CreateDiskSCAN.Size = new System.Drawing.Size(147, 34);
            this.button1CreateDiskSCAN.TabIndex = 17;
            this.button1CreateDiskSCAN.Text = "Create disk SCAN";
            this.button1CreateDiskSCAN.UseVisualStyleBackColor = true;
            this.button1CreateDiskSCAN.Click += new System.EventHandler(this.button1CreateDiskSCAN_Click);
            // 
            // buttonCreateDiskCSCAN
            // 
            this.buttonCreateDiskCSCAN.Location = new System.Drawing.Point(197, 208);
            this.buttonCreateDiskCSCAN.Name = "buttonCreateDiskCSCAN";
            this.buttonCreateDiskCSCAN.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDiskCSCAN.TabIndex = 18;
            this.buttonCreateDiskCSCAN.Text = "Create disk C-SCAN";
            this.buttonCreateDiskCSCAN.UseVisualStyleBackColor = true;
            this.buttonCreateDiskCSCAN.Click += new System.EventHandler(this.buttonCreateDiskCSCAN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Request deadline";
            // 
            // textBoxRequestDeadline
            // 
            this.textBoxRequestDeadline.Location = new System.Drawing.Point(819, 85);
            this.textBoxRequestDeadline.Name = "textBoxRequestDeadline";
            this.textBoxRequestDeadline.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestDeadline.TabIndex = 19;
            this.textBoxRequestDeadline.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(816, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Deadline +/- %";
            // 
            // textBoxReqestDeadlinePercent
            // 
            this.textBoxReqestDeadlinePercent.Location = new System.Drawing.Point(819, 130);
            this.textBoxReqestDeadlinePercent.Name = "textBoxReqestDeadlinePercent";
            this.textBoxReqestDeadlinePercent.Size = new System.Drawing.Size(100, 22);
            this.textBoxReqestDeadlinePercent.TabIndex = 21;
            this.textBoxReqestDeadlinePercent.Text = "40";
            // 
            // buttonCreateDiskFCFS_FDSCAN
            // 
            this.buttonCreateDiskFCFS_FDSCAN.Location = new System.Drawing.Point(350, 90);
            this.buttonCreateDiskFCFS_FDSCAN.Name = "buttonCreateDiskFCFS_FDSCAN";
            this.buttonCreateDiskFCFS_FDSCAN.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDiskFCFS_FDSCAN.TabIndex = 23;
            this.buttonCreateDiskFCFS_FDSCAN.Text = "FCFS FDSCAN";
            this.buttonCreateDiskFCFS_FDSCAN.UseVisualStyleBackColor = true;
            this.buttonCreateDiskFCFS_FDSCAN.Click += new System.EventHandler(this.buttonCreateDiskFCFS_FDSCAN_Click);
            // 
            // buttonCreateDiskSSTF_FDSCAN
            // 
            this.buttonCreateDiskSSTF_FDSCAN.Location = new System.Drawing.Point(350, 130);
            this.buttonCreateDiskSSTF_FDSCAN.Name = "buttonCreateDiskSSTF_FDSCAN";
            this.buttonCreateDiskSSTF_FDSCAN.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDiskSSTF_FDSCAN.TabIndex = 24;
            this.buttonCreateDiskSSTF_FDSCAN.Text = "SSTF FDSCAN";
            this.buttonCreateDiskSSTF_FDSCAN.UseVisualStyleBackColor = true;
            this.buttonCreateDiskSSTF_FDSCAN.Click += new System.EventHandler(this.buttonCreateDiskSSTF_FDSCAN_Click);
            // 
            // buttonCreateDiskSCAN_FDSCAN
            // 
            this.buttonCreateDiskSCAN_FDSCAN.Location = new System.Drawing.Point(350, 168);
            this.buttonCreateDiskSCAN_FDSCAN.Name = "buttonCreateDiskSCAN_FDSCAN";
            this.buttonCreateDiskSCAN_FDSCAN.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDiskSCAN_FDSCAN.TabIndex = 25;
            this.buttonCreateDiskSCAN_FDSCAN.Text = "SCAN FDSCAN";
            this.buttonCreateDiskSCAN_FDSCAN.UseVisualStyleBackColor = true;
            this.buttonCreateDiskSCAN_FDSCAN.Click += new System.EventHandler(this.buttonCreateDiskSCAN_FDSCAN_Click);
            // 
            // buttonCreateDiskCSCAN_FDSCAN
            // 
            this.buttonCreateDiskCSCAN_FDSCAN.Location = new System.Drawing.Point(350, 208);
            this.buttonCreateDiskCSCAN_FDSCAN.Name = "buttonCreateDiskCSCAN_FDSCAN";
            this.buttonCreateDiskCSCAN_FDSCAN.Size = new System.Drawing.Size(147, 34);
            this.buttonCreateDiskCSCAN_FDSCAN.TabIndex = 26;
            this.buttonCreateDiskCSCAN_FDSCAN.Text = "C-SCAN FDSCAN";
            this.buttonCreateDiskCSCAN_FDSCAN.UseVisualStyleBackColor = true;
            this.buttonCreateDiskCSCAN_FDSCAN.Click += new System.EventHandler(this.buttonCreateDiskCSCAN_FDSCAN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 605);
            this.Controls.Add(this.buttonCreateDiskCSCAN_FDSCAN);
            this.Controls.Add(this.buttonCreateDiskSCAN_FDSCAN);
            this.Controls.Add(this.buttonCreateDiskSSTF_FDSCAN);
            this.Controls.Add(this.buttonCreateDiskFCFS_FDSCAN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReqestDeadlinePercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRequestDeadline);
            this.Controls.Add(this.buttonCreateDiskCSCAN);
            this.Controls.Add(this.button1CreateDiskSCAN);
            this.Controls.Add(this.buttonAddCustomRequest);
            this.Controls.Add(this.buttonCreateDiskSSTF);
            this.Controls.Add(this.buttonCopyList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRequestsRealTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRequestTimeEnterMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRequestRangeMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRequestStartMin);
            this.Controls.Add(this.buttonCreateDisk);
            this.Controls.Add(this.labelDiskSize);
            this.Controls.Add(this.textBoxDiskSize);
            this.Controls.Add(this.labelRequestCount);
            this.Controls.Add(this.textBoxRequestCount);
            this.Controls.Add(this.buttonGenerateRequests);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateRequests;
        private System.Windows.Forms.TextBox textBoxRequestCount;
        private System.Windows.Forms.Label labelRequestCount;
        private System.Windows.Forms.Label labelDiskSize;
        private System.Windows.Forms.TextBox textBoxDiskSize;
        private System.Windows.Forms.Button buttonCreateDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRequestStartMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRequestRangeMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRequestTimeEnterMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRequestsRealTime;
        private System.Windows.Forms.Button buttonCopyList;
        private System.Windows.Forms.Button buttonCreateDiskSSTF;
        private System.Windows.Forms.Button buttonAddCustomRequest;
        private System.Windows.Forms.Button button1CreateDiskSCAN;
        private System.Windows.Forms.Button buttonCreateDiskCSCAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRequestDeadline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReqestDeadlinePercent;
        private System.Windows.Forms.Button buttonCreateDiskFCFS_FDSCAN;
        private System.Windows.Forms.Button buttonCreateDiskSSTF_FDSCAN;
        private System.Windows.Forms.Button buttonCreateDiskSCAN_FDSCAN;
        private System.Windows.Forms.Button buttonCreateDiskCSCAN_FDSCAN;
    }
}

