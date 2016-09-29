namespace sellanalyze
{
    partial class home
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.manthBox = new System.Windows.Forms.ComboBox();
            this.monthlabel = new System.Windows.Forms.Label();
            this.storeBox = new System.Windows.Forms.ComboBox();
            this.storelabel = new System.Windows.Forms.Label();
            this.anabutton = new System.Windows.Forms.Button();
            this.analabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pathchangemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.updownbutton = new System.Windows.Forms.NumericUpDown();
            this.oldtimerange = new System.Windows.Forms.DateTimePicker();
            this.rangelabel = new System.Windows.Forms.Label();
            this.kara = new System.Windows.Forms.Label();
            this.newtimerange = new System.Windows.Forms.DateTimePicker();
            this.oldtextlabel = new System.Windows.Forms.Label();
            this.newtimelabel = new System.Windows.Forms.Label();
            this.denlist = new System.Windows.Forms.ListView();
            this.denname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valuecolumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nouhincolumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // manthBox
            // 
            this.manthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.manthBox, "manthBox");
            this.manthBox.FormattingEnabled = true;
            this.manthBox.Items.AddRange(new object[] {
            resources.GetString("manthBox.Items"),
            resources.GetString("manthBox.Items1"),
            resources.GetString("manthBox.Items2"),
            resources.GetString("manthBox.Items3"),
            resources.GetString("manthBox.Items4"),
            resources.GetString("manthBox.Items5"),
            resources.GetString("manthBox.Items6"),
            resources.GetString("manthBox.Items7"),
            resources.GetString("manthBox.Items8"),
            resources.GetString("manthBox.Items9"),
            resources.GetString("manthBox.Items10"),
            resources.GetString("manthBox.Items11")});
            this.manthBox.Name = "manthBox";
            this.manthBox.SelectedIndexChanged += new System.EventHandler(this.manthBox_SelectedIndexChanged);
            // 
            // monthlabel
            // 
            this.monthlabel.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.monthlabel, "monthlabel");
            this.monthlabel.Name = "monthlabel";
            // 
            // storeBox
            // 
            this.storeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.storeBox, "storeBox");
            this.storeBox.FormattingEnabled = true;
            this.storeBox.Name = "storeBox";
            this.storeBox.SelectedIndexChanged += new System.EventHandler(this.storeBox_SelectedIndexChanged);
            // 
            // storelabel
            // 
            resources.ApplyResources(this.storelabel, "storelabel");
            this.storelabel.Name = "storelabel";
            // 
            // anabutton
            // 
            resources.ApplyResources(this.anabutton, "anabutton");
            this.anabutton.Name = "anabutton";
            this.anabutton.UseVisualStyleBackColor = true;
            this.anabutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // analabel
            // 
            resources.ApplyResources(this.analabel, "analabel");
            this.analabel.Name = "analabel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathchangemenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // pathchangemenu
            // 
            resources.ApplyResources(this.pathchangemenu, "pathchangemenu");
            this.pathchangemenu.Name = "pathchangemenu";
            this.pathchangemenu.Click += new System.EventHandler(this.pathchangemenu_Click);
            // 
            // updownbutton
            // 
            resources.ApplyResources(this.updownbutton, "updownbutton");
            this.updownbutton.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.updownbutton.Name = "updownbutton";
            this.updownbutton.ValueChanged += new System.EventHandler(this.updownbutton_ValueChanged);
            // 
            // oldtimerange
            // 
            resources.ApplyResources(this.oldtimerange, "oldtimerange");
            this.oldtimerange.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.oldtimerange.Name = "oldtimerange";
            this.oldtimerange.Value = new System.DateTime(2016, 9, 10, 0, 0, 0, 0);
            this.oldtimerange.ValueChanged += new System.EventHandler(this.oldtimerange_ValueChanged);
            // 
            // rangelabel
            // 
            resources.ApplyResources(this.rangelabel, "rangelabel");
            this.rangelabel.Name = "rangelabel";
            // 
            // kara
            // 
            resources.ApplyResources(this.kara, "kara");
            this.kara.Name = "kara";
            // 
            // newtimerange
            // 
            resources.ApplyResources(this.newtimerange, "newtimerange");
            this.newtimerange.Name = "newtimerange";
            this.newtimerange.ValueChanged += new System.EventHandler(this.newtimerange_ValueChanged);
            // 
            // oldtextlabel
            // 
            resources.ApplyResources(this.oldtextlabel, "oldtextlabel");
            this.oldtextlabel.Name = "oldtextlabel";
            // 
            // newtimelabel
            // 
            resources.ApplyResources(this.newtimelabel, "newtimelabel");
            this.newtimelabel.Name = "newtimelabel";
            // 
            // denlist
            // 
            this.denlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.denname,
            this.valuecolumu,
            this.nouhincolumu});
            resources.ApplyResources(this.denlist, "denlist");
            this.denlist.GridLines = true;
            this.denlist.Name = "denlist";
            this.denlist.UseCompatibleStateImageBehavior = false;
            this.denlist.View = System.Windows.Forms.View.Details;
            // 
            // denname
            // 
            resources.ApplyResources(this.denname, "denname");
            // 
            // valuecolumu
            // 
            resources.ApplyResources(this.valuecolumu, "valuecolumu");
            // 
            // nouhincolumu
            // 
            resources.ApplyResources(this.nouhincolumu, "nouhincolumu");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.denlist);
            this.Controls.Add(this.newtimelabel);
            this.Controls.Add(this.oldtextlabel);
            this.Controls.Add(this.newtimerange);
            this.Controls.Add(this.kara);
            this.Controls.Add(this.rangelabel);
            this.Controls.Add(this.oldtimerange);
            this.Controls.Add(this.updownbutton);
            this.Controls.Add(this.analabel);
            this.Controls.Add(this.anabutton);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.storeBox);
            this.Controls.Add(this.monthlabel);
            this.Controls.Add(this.manthBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox manthBox;
        private System.Windows.Forms.Label monthlabel;
        private System.Windows.Forms.ComboBox storeBox;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.Button anabutton;
        private System.Windows.Forms.Label analabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pathchangemenu;
        private System.Windows.Forms.NumericUpDown updownbutton;
        private System.Windows.Forms.DateTimePicker oldtimerange;
        private System.Windows.Forms.Label rangelabel;
        private System.Windows.Forms.Label kara;
        private System.Windows.Forms.DateTimePicker newtimerange;
        private System.Windows.Forms.Label oldtextlabel;
        private System.Windows.Forms.Label newtimelabel;
        private System.Windows.Forms.ListView denlist;
        private System.Windows.Forms.ColumnHeader denname;
        private System.Windows.Forms.ColumnHeader valuecolumu;
        private System.Windows.Forms.ColumnHeader nouhincolumu;
        private System.Windows.Forms.Label label1;
    }
}

