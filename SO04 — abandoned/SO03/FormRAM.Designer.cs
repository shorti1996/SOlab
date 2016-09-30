namespace SO03
{
    partial class FormRAM
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
            this.dataGridViewPhysical = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhysical)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhysical
            // 
            this.dataGridViewPhysical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhysical.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPhysical.Name = "dataGridViewPhysical";
            this.dataGridViewPhysical.RowTemplate.Height = 24;
            this.dataGridViewPhysical.Size = new System.Drawing.Size(627, 311);
            this.dataGridViewPhysical.TabIndex = 0;
            // 
            // FormRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 504);
            this.Controls.Add(this.dataGridViewPhysical);
            this.Name = "FormRAM";
            this.Text = "FormRAM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhysical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhysical;
    }
}