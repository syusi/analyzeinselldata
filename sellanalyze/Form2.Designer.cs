namespace sellanalyze
{
    partial class Form2
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
            this.datadrop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datadrop
            // 
            this.datadrop.AllowDrop = true;
            this.datadrop.BackColor = System.Drawing.SystemColors.Highlight;
            this.datadrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datadrop.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.datadrop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datadrop.Location = new System.Drawing.Point(0, 0);
            this.datadrop.Name = "datadrop";
            this.datadrop.Size = new System.Drawing.Size(382, 305);
            this.datadrop.TabIndex = 5;
            this.datadrop.Text = "ここにデータを\r\nドラックドロップ";
            this.datadrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.datadrop_DragDrop);
            this.datadrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.datadrop_DragEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 305);
            this.Controls.Add(this.datadrop);
            this.Name = "Form2";
            this.Text = "change";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label datadrop;
    }
}