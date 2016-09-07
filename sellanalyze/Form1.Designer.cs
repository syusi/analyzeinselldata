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
            this.datadrop = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.伝票no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eos伝票 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.売り上げ区分 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.納品日 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.得意先コード = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.得意先コード２ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.は = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ひ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.空白 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ふ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.合計金額 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.売りか合計金額 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.売上合計金額 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.消費税 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.コメント欄 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.へ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.伝票入力日 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ほ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.わからん = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.analabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manthBox
            // 
            this.manthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manthBox.FormattingEnabled = true;
            resources.ApplyResources(this.manthBox, "manthBox");
            this.manthBox.Name = "manthBox";
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
            this.storeBox.FormattingEnabled = true;
            resources.ApplyResources(this.storeBox, "storeBox");
            this.storeBox.Name = "storeBox";
            // 
            // storelabel
            // 
            resources.ApplyResources(this.storelabel, "storelabel");
            this.storelabel.Name = "storelabel";
            // 
            // datadrop
            // 
            this.datadrop.AllowDrop = true;
            this.datadrop.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.datadrop, "datadrop");
            this.datadrop.Name = "datadrop";
            this.datadrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.datadrop_DragDrop);
            this.datadrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.datadrop_DragEnter);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.伝票no,
            this.eos伝票,
            this.売り上げ区分,
            this.納品日,
            this.得意先コード,
            this.得意先コード２,
            this.は,
            this.ひ,
            this.空白,
            this.ふ,
            this.合計金額,
            this.売りか合計金額,
            this.売上合計金額,
            this.消費税,
            this.コメント欄,
            this.へ,
            this.伝票入力日,
            this.ほ,
            this.わからん});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items")))});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 伝票no
            // 
            resources.ApplyResources(this.伝票no, "伝票no");
            // 
            // eos伝票
            // 
            resources.ApplyResources(this.eos伝票, "eos伝票");
            // 
            // 売り上げ区分
            // 
            resources.ApplyResources(this.売り上げ区分, "売り上げ区分");
            // 
            // 納品日
            // 
            resources.ApplyResources(this.納品日, "納品日");
            // 
            // 得意先コード
            // 
            resources.ApplyResources(this.得意先コード, "得意先コード");
            // 
            // 得意先コード２
            // 
            resources.ApplyResources(this.得意先コード２, "得意先コード２");
            // 
            // は
            // 
            resources.ApplyResources(this.は, "は");
            // 
            // ひ
            // 
            resources.ApplyResources(this.ひ, "ひ");
            // 
            // 空白
            // 
            resources.ApplyResources(this.空白, "空白");
            // 
            // ふ
            // 
            resources.ApplyResources(this.ふ, "ふ");
            // 
            // 合計金額
            // 
            resources.ApplyResources(this.合計金額, "合計金額");
            // 
            // 売りか合計金額
            // 
            resources.ApplyResources(this.売りか合計金額, "売りか合計金額");
            // 
            // 売上合計金額
            // 
            resources.ApplyResources(this.売上合計金額, "売上合計金額");
            // 
            // 消費税
            // 
            resources.ApplyResources(this.消費税, "消費税");
            // 
            // コメント欄
            // 
            resources.ApplyResources(this.コメント欄, "コメント欄");
            // 
            // へ
            // 
            resources.ApplyResources(this.へ, "へ");
            // 
            // 伝票入力日
            // 
            resources.ApplyResources(this.伝票入力日, "伝票入力日");
            // 
            // ほ
            // 
            resources.ApplyResources(this.ほ, "ほ");
            // 
            // わからん
            // 
            resources.ApplyResources(this.わからん, "わからん");
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // analabel
            // 
            resources.ApplyResources(this.analabel, "analabel");
            this.analabel.Name = "analabel";
            // 
            // home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.analabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datadrop);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.storeBox);
            this.Controls.Add(this.monthlabel);
            this.Controls.Add(this.manthBox);
            this.Name = "home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox manthBox;
        private System.Windows.Forms.Label monthlabel;
        private System.Windows.Forms.ComboBox storeBox;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.Label datadrop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 伝票no;
        private System.Windows.Forms.ColumnHeader eos伝票;
        private System.Windows.Forms.ColumnHeader 売り上げ区分;
        private System.Windows.Forms.ColumnHeader 納品日;
        private System.Windows.Forms.ColumnHeader 得意先コード;
        private System.Windows.Forms.ColumnHeader 得意先コード２;
        private System.Windows.Forms.ColumnHeader は;
        private System.Windows.Forms.ColumnHeader ひ;
        private System.Windows.Forms.ColumnHeader 空白;
        private System.Windows.Forms.ColumnHeader ふ;
        private System.Windows.Forms.ColumnHeader 合計金額;
        private System.Windows.Forms.ColumnHeader 売りか合計金額;
        private System.Windows.Forms.ColumnHeader 売上合計金額;
        private System.Windows.Forms.ColumnHeader 消費税;
        private System.Windows.Forms.ColumnHeader コメント欄;
        private System.Windows.Forms.ColumnHeader へ;
        private System.Windows.Forms.ColumnHeader 伝票入力日;
        private System.Windows.Forms.ColumnHeader ほ;
        private System.Windows.Forms.ColumnHeader わからん;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label analabel;
    }
}

