namespace sellanalyze
{
    partial class Goodsrank
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
            this.goodsListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.情報を変えるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Goodsnamelabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.並び順を変えるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsListView
            // 
            this.goodsListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goodsListView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.goodsListView.GridLines = true;
            this.goodsListView.Location = new System.Drawing.Point(0, 64);
            this.goodsListView.Name = "goodsListView";
            this.goodsListView.Size = new System.Drawing.Size(729, 405);
            this.goodsListView.TabIndex = 0;
            this.goodsListView.UseCompatibleStateImageBehavior = false;
            this.goodsListView.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.情報を変えるToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 情報を変えるToolStripMenuItem
            // 
            this.情報を変えるToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthMenuItem,
            this.storeMenuItem});
            this.情報を変えるToolStripMenuItem.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.情報を変えるToolStripMenuItem.Name = "情報を変えるToolStripMenuItem";
            this.情報を変えるToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.情報を変えるToolStripMenuItem.Text = "表示を変える";
            // 
            // monthMenuItem
            // 
            this.monthMenuItem.Name = "monthMenuItem";
            this.monthMenuItem.Size = new System.Drawing.Size(181, 34);
            this.monthMenuItem.Text = "月別";
            this.monthMenuItem.Click += new System.EventHandler(this.monthMenuItem_Click);
            // 
            // storeMenuItem
            // 
            this.storeMenuItem.Name = "storeMenuItem";
            this.storeMenuItem.Size = new System.Drawing.Size(181, 34);
            this.storeMenuItem.Text = "店別";
            this.storeMenuItem.Click += new System.EventHandler(this.storeMenuItem_Click);
            // 
            // Goodsnamelabel
            // 
            this.Goodsnamelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Goodsnamelabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Goodsnamelabel.Location = new System.Drawing.Point(0, 38);
            this.Goodsnamelabel.Name = "Goodsnamelabel";
            this.Goodsnamelabel.Size = new System.Drawing.Size(729, 23);
            this.Goodsnamelabel.TabIndex = 2;
            this.Goodsnamelabel.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("メイリオ", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.並び順を変えるToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 36);
            // 
            // 並び順を変えるToolStripMenuItem
            // 
            this.並び順を変えるToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.numToolStripMenuItem});
            this.並び順を変えるToolStripMenuItem.Name = "並び順を変えるToolStripMenuItem";
            this.並び順を変えるToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.並び順を変えるToolStripMenuItem.Text = "並び順を変える";
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.monthToolStripMenuItem.Text = "月順";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.storeToolStripMenuItem.Text = "店(50音)順";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // numToolStripMenuItem
            // 
            this.numToolStripMenuItem.Name = "numToolStripMenuItem";
            this.numToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.numToolStripMenuItem.Text = "売り上げ数順";
            this.numToolStripMenuItem.Click += new System.EventHandler(this.numToolStripMenuItem_Click);
            // 
            // Goodsrank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 469);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Goodsnamelabel);
            this.Controls.Add(this.goodsListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Goodsrank";
            this.Text = "GoodsRank";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView goodsListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 情報を変えるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeMenuItem;
        private System.Windows.Forms.Label Goodsnamelabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 並び順を変えるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numToolStripMenuItem;
    }
}