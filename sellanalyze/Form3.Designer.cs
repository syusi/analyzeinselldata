namespace sellanalyze
{
    partial class Form3
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
            this.rank = new System.Windows.Forms.Label();
            this.ranklistView = new System.Windows.Forms.ListView();
            this.rankcolumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.syouhimcolumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellnumcolumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indexchangeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.並び順を変えるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexchangeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rank
            // 
            this.rank.Dock = System.Windows.Forms.DockStyle.Top;
            this.rank.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rank.Location = new System.Drawing.Point(0, 0);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(642, 22);
            this.rank.TabIndex = 0;
            this.rank.Text = "ランキング\r\n";
            // 
            // ranklistView
            // 
            this.ranklistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rankcolumu,
            this.syouhimcolumu,
            this.sellnumcolumu});
            this.ranklistView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ranklistView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ranklistView.FullRowSelect = true;
            this.ranklistView.GridLines = true;
            this.ranklistView.Location = new System.Drawing.Point(0, 25);
            this.ranklistView.MultiSelect = false;
            this.ranklistView.Name = "ranklistView";
            this.ranklistView.Size = new System.Drawing.Size(642, 430);
            this.ranklistView.TabIndex = 1;
            this.ranklistView.UseCompatibleStateImageBehavior = false;
            this.ranklistView.View = System.Windows.Forms.View.Details;
            this.ranklistView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ranklistView_ItemSelectionChanged);
            // 
            // rankcolumu
            // 
            this.rankcolumu.Text = "順位";
            // 
            // syouhimcolumu
            // 
            this.syouhimcolumu.Text = "商品名";
            this.syouhimcolumu.Width = 301;
            // 
            // sellnumcolumu
            // 
            this.sellnumcolumu.Text = "売数";
            this.sellnumcolumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sellnumcolumu.Width = 100;
            // 
            // indexchangeMenu
            // 
            this.indexchangeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.indexchangeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.並び順を変えるToolStripMenuItem});
            this.indexchangeMenu.Name = "indexchangeMenu";
            this.indexchangeMenu.Size = new System.Drawing.Size(230, 38);
            // 
            // 並び順を変えるToolStripMenuItem
            // 
            this.並び順を変えるToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.並び順を変えるToolStripMenuItem.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.並び順を変えるToolStripMenuItem.Name = "並び順を変えるToolStripMenuItem";
            this.並び順を変えるToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.並び順を変えるToolStripMenuItem.Text = "並び順を変える";
            // 
            // rankToolStripMenuItem
            // 
            this.rankToolStripMenuItem.Name = "rankToolStripMenuItem";
            this.rankToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
            this.rankToolStripMenuItem.Text = "順位";
            this.rankToolStripMenuItem.Click += new System.EventHandler(this.rankToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
            this.nameToolStripMenuItem.Text = "名前";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 455);
            this.ContextMenuStrip = this.indexchangeMenu;
            this.Controls.Add(this.ranklistView);
            this.Controls.Add(this.rank);
            this.Name = "Form3";
            this.Text = "Form3";
            this.indexchangeMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.ListView ranklistView;
        private System.Windows.Forms.ColumnHeader rankcolumu;
        private System.Windows.Forms.ColumnHeader sellnumcolumu;
        private System.Windows.Forms.ColumnHeader syouhimcolumu;
        private System.Windows.Forms.ContextMenuStrip indexchangeMenu;
        private System.Windows.Forms.ToolStripMenuItem 並び順を変えるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
    }
}