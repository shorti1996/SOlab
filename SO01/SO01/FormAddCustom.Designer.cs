namespace SO01
{
    partial class FormAddCustom
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
            this.labelTimeStartMax = new System.Windows.Forms.Label();
            this.labelTimeStartMin = new System.Windows.Forms.Label();
            this.labelLifeTimeMax = new System.Windows.Forms.Label();
            this.labelLifeTimeMin = new System.Windows.Forms.Label();
            this.labelProcessCount = new System.Windows.Forms.Label();
            this.textBoxTimeStartMax = new System.Windows.Forms.TextBox();
            this.textBoxTimeStartMin = new System.Windows.Forms.TextBox();
            this.textBoxLifeTimeMax = new System.Windows.Forms.TextBox();
            this.textBoxLifeTimeMin = new System.Windows.Forms.TextBox();
            this.textBoxProcessCount = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonMake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTimeStart = new System.Windows.Forms.TextBox();
            this.textBoxLifeTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTimeStartMax
            // 
            this.labelTimeStartMax.AutoSize = true;
            this.labelTimeStartMax.Location = new System.Drawing.Point(170, 62);
            this.labelTimeStartMax.Name = "labelTimeStartMax";
            this.labelTimeStartMax.Size = new System.Drawing.Size(95, 17);
            this.labelTimeStartMax.TabIndex = 30;
            this.labelTimeStartMax.Text = "TimeStart Min";
            // 
            // labelTimeStartMin
            // 
            this.labelTimeStartMin.AutoSize = true;
            this.labelTimeStartMin.Location = new System.Drawing.Point(64, 62);
            this.labelTimeStartMin.Name = "labelTimeStartMin";
            this.labelTimeStartMin.Size = new System.Drawing.Size(95, 17);
            this.labelTimeStartMin.TabIndex = 29;
            this.labelTimeStartMin.Text = "TimeStart Min";
            // 
            // labelLifeTimeMax
            // 
            this.labelLifeTimeMax.AutoSize = true;
            this.labelLifeTimeMax.Location = new System.Drawing.Point(170, 9);
            this.labelLifeTimeMax.Name = "labelLifeTimeMax";
            this.labelLifeTimeMax.Size = new System.Drawing.Size(91, 17);
            this.labelLifeTimeMax.TabIndex = 28;
            this.labelLifeTimeMax.Text = "LifeTime Max";
            // 
            // labelLifeTimeMin
            // 
            this.labelLifeTimeMin.AutoSize = true;
            this.labelLifeTimeMin.Location = new System.Drawing.Point(64, 9);
            this.labelLifeTimeMin.Name = "labelLifeTimeMin";
            this.labelLifeTimeMin.Size = new System.Drawing.Size(88, 17);
            this.labelLifeTimeMin.TabIndex = 27;
            this.labelLifeTimeMin.Text = "LifeTime Min";
            // 
            // labelProcessCount
            // 
            this.labelProcessCount.AutoSize = true;
            this.labelProcessCount.Location = new System.Drawing.Point(12, 9);
            this.labelProcessCount.Name = "labelProcessCount";
            this.labelProcessCount.Size = new System.Drawing.Size(45, 17);
            this.labelProcessCount.TabIndex = 26;
            this.labelProcessCount.Text = "Count";
            // 
            // textBoxTimeStartMax
            // 
            this.textBoxTimeStartMax.Location = new System.Drawing.Point(173, 82);
            this.textBoxTimeStartMax.Name = "textBoxTimeStartMax";
            this.textBoxTimeStartMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeStartMax.TabIndex = 25;
            this.textBoxTimeStartMax.Text = "30000";
            // 
            // textBoxTimeStartMin
            // 
            this.textBoxTimeStartMin.Location = new System.Drawing.Point(67, 82);
            this.textBoxTimeStartMin.Name = "textBoxTimeStartMin";
            this.textBoxTimeStartMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeStartMin.TabIndex = 24;
            this.textBoxTimeStartMin.Text = "0";
            // 
            // textBoxLifeTimeMax
            // 
            this.textBoxLifeTimeMax.Location = new System.Drawing.Point(173, 29);
            this.textBoxLifeTimeMax.Name = "textBoxLifeTimeMax";
            this.textBoxLifeTimeMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxLifeTimeMax.TabIndex = 23;
            this.textBoxLifeTimeMax.Text = "500";
            // 
            // textBoxLifeTimeMin
            // 
            this.textBoxLifeTimeMin.Location = new System.Drawing.Point(67, 29);
            this.textBoxLifeTimeMin.Name = "textBoxLifeTimeMin";
            this.textBoxLifeTimeMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLifeTimeMin.TabIndex = 22;
            this.textBoxLifeTimeMin.Text = "100";
            // 
            // textBoxProcessCount
            // 
            this.textBoxProcessCount.Location = new System.Drawing.Point(15, 29);
            this.textBoxProcessCount.Name = "textBoxProcessCount";
            this.textBoxProcessCount.Size = new System.Drawing.Size(46, 22);
            this.textBoxProcessCount.TabIndex = 21;
            this.textBoxProcessCount.Text = "20";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 110);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(85, 23);
            this.buttonGenerate.TabIndex = 31;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(12, 258);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(75, 23);
            this.buttonMake.TabIndex = 32;
            this.buttonMake.Text = "Make";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "TimeStart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "LifeTime";
            // 
            // textBoxTimeStart
            // 
            this.textBoxTimeStart.Location = new System.Drawing.Point(64, 230);
            this.textBoxTimeStart.Name = "textBoxTimeStart";
            this.textBoxTimeStart.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeStart.TabIndex = 36;
            this.textBoxTimeStart.Text = "0";
            // 
            // textBoxLifeTime
            // 
            this.textBoxLifeTime.Location = new System.Drawing.Point(64, 177);
            this.textBoxLifeTime.Name = "textBoxLifeTime";
            this.textBoxLifeTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxLifeTime.TabIndex = 34;
            this.textBoxLifeTime.Text = "100";
            // 
            // FormAddCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTimeStart);
            this.Controls.Add(this.textBoxLifeTime);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelTimeStartMax);
            this.Controls.Add(this.labelTimeStartMin);
            this.Controls.Add(this.labelLifeTimeMax);
            this.Controls.Add(this.labelLifeTimeMin);
            this.Controls.Add(this.labelProcessCount);
            this.Controls.Add(this.textBoxTimeStartMax);
            this.Controls.Add(this.textBoxTimeStartMin);
            this.Controls.Add(this.textBoxLifeTimeMax);
            this.Controls.Add(this.textBoxLifeTimeMin);
            this.Controls.Add(this.textBoxProcessCount);
            this.Name = "FormAddCustom";
            this.Text = "FormAddCustom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeStartMax;
        private System.Windows.Forms.Label labelTimeStartMin;
        private System.Windows.Forms.Label labelLifeTimeMax;
        private System.Windows.Forms.Label labelLifeTimeMin;
        private System.Windows.Forms.Label labelProcessCount;
        private System.Windows.Forms.TextBox textBoxTimeStartMax;
        private System.Windows.Forms.TextBox textBoxTimeStartMin;
        private System.Windows.Forms.TextBox textBoxLifeTimeMax;
        private System.Windows.Forms.TextBox textBoxLifeTimeMin;
        private System.Windows.Forms.TextBox textBoxProcessCount;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTimeStart;
        private System.Windows.Forms.TextBox textBoxLifeTime;
    }
}