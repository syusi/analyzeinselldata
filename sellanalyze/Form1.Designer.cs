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
            this.manthBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.manthBox.FormattingEnabled = true;
            this.manthBox.Items.AddRange(new object[] {
            "１月",
            "２月",
            "３月",
            "４月",
            "５月",
            "６月",
            "７月",
            "８月",
            "９月",
            "１０月",
            "１１月",
            "１２月"});
            this.manthBox.Location = new System.Drawing.Point(48, 366);
            this.manthBox.Name = "manthBox";
            this.manthBox.Size = new System.Drawing.Size(121, 28);
            this.manthBox.TabIndex = 0;
            this.manthBox.SelectedIndexChanged += new System.EventHandler(this.manthBox_SelectedIndexChanged);
            // 
            // monthlabel
            // 
            this.monthlabel.BackColor = System.Drawing.SystemColors.Control;
            this.monthlabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.monthlabel.Location = new System.Drawing.Point(44, 320);
            this.monthlabel.Name = "monthlabel";
            this.monthlabel.Size = new System.Drawing.Size(150, 43);
            this.monthlabel.TabIndex = 1;
            this.monthlabel.Text = "月の売り上げ";
            // 
            // storeBox
            // 
            this.storeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.storeBox.FormattingEnabled = true;
            this.storeBox.Location = new System.Drawing.Point(21, 484);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(192, 28);
            this.storeBox.TabIndex = 2;
            this.storeBox.SelectedIndexChanged += new System.EventHandler(this.storeBox_SelectedIndexChanged);
            // 
            // storelabel
            // 
            this.storelabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.storelabel.Location = new System.Drawing.Point(44, 438);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(146, 39);
            this.storelabel.TabIndex = 3;
            this.storelabel.Text = "店の売り上げ";
            // 
            // anabutton
            // 
            this.anabutton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.anabutton.Location = new System.Drawing.Point(577, 73);
            this.anabutton.Name = "anabutton";
            this.anabutton.Size = new System.Drawing.Size(140, 53);
            this.anabutton.TabIndex = 7;
            this.anabutton.Text = "分析開始";
            this.anabutton.UseVisualStyleBackColor = true;
            this.anabutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // analabel
            // 
            this.analabel.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.analabel.Location = new System.Drawing.Point(249, 181);
            this.analabel.Name = "analabel";
            this.analabel.Size = new System.Drawing.Size(818, 281);
            this.analabel.TabIndex = 8;
            this.analabel.Text = "データ分析";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathchangemenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pathchangemenu
            // 
            this.pathchangemenu.Font = new System.Drawing.Font("メイリオ", 10.8F);
            this.pathchangemenu.Name = "pathchangemenu";
            this.pathchangemenu.Size = new System.Drawing.Size(176, 32);
            this.pathchangemenu.Text = "ディレクトリ変更";
            this.pathchangemenu.Click += new System.EventHandler(this.pathchangemenu_Click);
            // 
            // updownbutton
            // 
            this.updownbutton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.updownbutton.Location = new System.Drawing.Point(49, 259);
            this.updownbutton.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.updownbutton.Name = "updownbutton";
            this.updownbutton.Size = new System.Drawing.Size(120, 30);
            this.updownbutton.TabIndex = 10;
            this.updownbutton.ValueChanged += new System.EventHandler(this.updownbutton_ValueChanged);
            // 
            // oldtimerange
            // 
            this.oldtimerange.CalendarFont = new System.Drawing.Font("MS UI Gothic", 9F);
            this.oldtimerange.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.oldtimerange.Location = new System.Drawing.Point(8, 99);
            this.oldtimerange.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.oldtimerange.Name = "oldtimerange";
            this.oldtimerange.Size = new System.Drawing.Size(225, 30);
            this.oldtimerange.TabIndex = 11;
            this.oldtimerange.Value = new System.DateTime(2016, 9, 10, 0, 0, 0, 0);
            this.oldtimerange.ValueChanged += new System.EventHandler(this.oldtimerange_ValueChanged);
            // 
            // rangelabel
            // 
            this.rangelabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.rangelabel.Location = new System.Drawing.Point(168, 39);
            this.rangelabel.Name = "rangelabel";
            this.rangelabel.Size = new System.Drawing.Size(198, 42);
            this.rangelabel.TabIndex = 12;
            this.rangelabel.Text = "集計範囲";
            // 
            // kara
            // 
            this.kara.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.kara.Location = new System.Drawing.Point(239, 99);
            this.kara.Name = "kara";
            this.kara.Size = new System.Drawing.Size(30, 15);
            this.kara.TabIndex = 13;
            this.kara.Text = "～";
            // 
            // newtimerange
            // 
            this.newtimerange.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.newtimerange.Location = new System.Drawing.Point(286, 99);
            this.newtimerange.Name = "newtimerange";
            this.newtimerange.Size = new System.Drawing.Size(200, 30);
            this.newtimerange.TabIndex = 14;
            this.newtimerange.ValueChanged += new System.EventHandler(this.newtimerange_ValueChanged);
            // 
            // oldtextlabel
            // 
            this.oldtextlabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.oldtextlabel.Location = new System.Drawing.Point(57, 66);
            this.oldtextlabel.Name = "oldtextlabel";
            this.oldtextlabel.Size = new System.Drawing.Size(200, 30);
            this.oldtextlabel.TabIndex = 15;
            this.oldtextlabel.Text = "範囲(始点)";
            // 
            // newtimelabel
            // 
            this.newtimelabel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.newtimelabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newtimelabel.Location = new System.Drawing.Point(317, 66);
            this.newtimelabel.Name = "newtimelabel";
            this.newtimelabel.Size = new System.Drawing.Size(200, 30);
            this.newtimelabel.TabIndex = 16;
            this.newtimelabel.Text = "範囲(終点)";
            // 
            // denlist
            // 
            this.denlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.denname,
            this.valuecolumu,
            this.nouhincolumu});
            this.denlist.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.denlist.GridLines = true;
            this.denlist.Location = new System.Drawing.Point(253, 214);
            this.denlist.Name = "denlist";
            this.denlist.Size = new System.Drawing.Size(804, 248);
            this.denlist.TabIndex = 17;
            this.denlist.UseCompatibleStateImageBehavior = false;
            this.denlist.View = System.Windows.Forms.View.Details;
            // 
            // denname
            // 
            this.denname.Text = "商品名";
            this.denname.Width = 370;
            // 
            // valuecolumu
            // 
            this.valuecolumu.Text = "納品単価";
            this.valuecolumu.Width = 120;
            // 
            // nouhincolumu
            // 
            this.nouhincolumu.Text = "納品個数";
            this.nouhincolumu.Width = 100;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "集計伝票(詳細)";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1382, 555);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "home";
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

