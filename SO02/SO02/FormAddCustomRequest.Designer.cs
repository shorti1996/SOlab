namespace SO02
{
    partial class FormAddCustomRequest
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRequestEnd = new System.Windows.Forms.TextBox();
            this.labelRequestStart = new System.Windows.Forms.Label();
            this.textBoxRequestStart = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimeEnter = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Request End";
            // 
            // textBoxRequestEnd
            // 
            this.textBoxRequestEnd.Location = new System.Drawing.Point(145, 29);
            this.textBoxRequestEnd.Name = "textBoxRequestEnd";
            this.textBoxRequestEnd.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestEnd.TabIndex = 12;
            this.textBoxRequestEnd.Text = "10";
            // 
            // labelRequestStart
            // 
            this.labelRequestStart.AutoSize = true;
            this.labelRequestStart.Location = new System.Drawing.Point(12, 9);
            this.labelRequestStart.Name = "labelRequestStart";
            this.labelRequestStart.Size = new System.Drawing.Size(95, 17);
            this.labelRequestStart.TabIndex = 11;
            this.labelRequestStart.Text = "Request Start";
            // 
            // textBoxRequestStart
            // 
            this.textBoxRequestStart.Location = new System.Drawing.Point(15, 29);
            this.textBoxRequestStart.Name = "textBoxRequestStart";
            this.textBoxRequestStart.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequestStart.TabIndex = 10;
            this.textBoxRequestStart.Text = "1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBox1.Location = new System.Drawing.Point(266, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Realtime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "TimeEnter";
            // 
            // textBoxTimeEnter
            // 
            this.textBoxTimeEnter.Location = new System.Drawing.Point(416, 29);
            this.textBoxTimeEnter.Name = "textBoxTimeEnter";
            this.textBoxTimeEnter.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeEnter.TabIndex = 16;
            this.textBoxTimeEnter.Text = "10";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 75);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAddCustomRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 359);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRequestEnd);
            this.Controls.Add(this.labelRequestStart);
            this.Controls.Add(this.textBoxRequestStart);
            this.Name = "FormAddCustomRequest";
            this.Text = "FormAddCustomRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRequestEnd;
        private System.Windows.Forms.Label labelRequestStart;
        private System.Windows.Forms.TextBox textBoxRequestStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimeEnter;
        private System.Windows.Forms.Button buttonOK;
    }
}