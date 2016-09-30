namespace SO01
{
    partial class Process
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
            this.textBoxTimeRunning = new System.Windows.Forms.TextBox();
            this.textBoxTimeLeft = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTimeRunning
            // 
            this.textBoxTimeRunning.Location = new System.Drawing.Point(12, 114);
            this.textBoxTimeRunning.Name = "textBoxTimeRunning";
            this.textBoxTimeRunning.Size = new System.Drawing.Size(167, 22);
            this.textBoxTimeRunning.TabIndex = 0;
            // 
            // textBoxTimeLeft
            // 
            this.textBoxTimeLeft.Location = new System.Drawing.Point(12, 190);
            this.textBoxTimeLeft.Name = "textBoxTimeLeft";
            this.textBoxTimeLeft.Size = new System.Drawing.Size(167, 22);
            this.textBoxTimeLeft.TabIndex = 1;
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 412);
            this.Controls.Add(this.textBoxTimeLeft);
            this.Controls.Add(this.textBoxTimeRunning);
            this.Name = "Process";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTimeRunning;
        private System.Windows.Forms.TextBox textBoxTimeLeft;
    }
}

