namespace SO03
{
    partial class FormManager
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
            this.labelVirtualMemSize = new System.Windows.Forms.Label();
            this.textBoxVirtualMemSize = new System.Windows.Forms.TextBox();
            this.labelPhysicalMemSize = new System.Windows.Forms.Label();
            this.textBoxPhysicalMemSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelVirtualMemSize
            // 
            this.labelVirtualMemSize.AutoSize = true;
            this.labelVirtualMemSize.Location = new System.Drawing.Point(12, 9);
            this.labelVirtualMemSize.Name = "labelVirtualMemSize";
            this.labelVirtualMemSize.Size = new System.Drawing.Size(131, 17);
            this.labelVirtualMemSize.TabIndex = 5;
            this.labelVirtualMemSize.Text = "Virtual memory size";
            // 
            // textBoxVirtualMemSize
            // 
            this.textBoxVirtualMemSize.Location = new System.Drawing.Point(12, 29);
            this.textBoxVirtualMemSize.Name = "textBoxVirtualMemSize";
            this.textBoxVirtualMemSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxVirtualMemSize.TabIndex = 6;
            this.textBoxVirtualMemSize.Text = "10";
            // 
            // labelPhysicalMemSize
            // 
            this.labelPhysicalMemSize.AutoSize = true;
            this.labelPhysicalMemSize.Location = new System.Drawing.Point(149, 9);
            this.labelPhysicalMemSize.Name = "labelPhysicalMemSize";
            this.labelPhysicalMemSize.Size = new System.Drawing.Size(143, 17);
            this.labelPhysicalMemSize.TabIndex = 7;
            this.labelPhysicalMemSize.Text = "Physical memory size";
            // 
            // textBoxPhysicalMemSize
            // 
            this.textBoxPhysicalMemSize.Location = new System.Drawing.Point(149, 29);
            this.textBoxPhysicalMemSize.Name = "textBoxPhysicalMemSize";
            this.textBoxPhysicalMemSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhysicalMemSize.TabIndex = 8;
            this.textBoxPhysicalMemSize.Text = "5";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 507);
            this.Controls.Add(this.labelVirtualMemSize);
            this.Controls.Add(this.textBoxVirtualMemSize);
            this.Controls.Add(this.labelPhysicalMemSize);
            this.Controls.Add(this.textBoxPhysicalMemSize);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVirtualMemSize;
        private System.Windows.Forms.TextBox textBoxVirtualMemSize;
        private System.Windows.Forms.Label labelPhysicalMemSize;
        private System.Windows.Forms.TextBox textBoxPhysicalMemSize;
    }
}