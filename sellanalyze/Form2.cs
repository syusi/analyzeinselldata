using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellanalyze
{
    public partial class Form2 : Form
    {
        string filepath;
        public Form2()
        {
            InitializeComponent();
            var sr = new StreamReader("config.txt", Encoding.GetEncoding("Shift_JIS"));
            if ((filepath = sr.ReadLine()) == null)
            {
                datadrop.Text = "データが入っているディレクトリを選択してください";
            }
            else
            {
                datadrop.Text = "現在のディレクトリは\n" + filepath + "です";
            }
            sr.Close();
        }
        private void datadrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void datadrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(file[0] + @"\turiden.txt"))
            {
                datadrop.Text = file[0] + "ディレクトリが選択されました";
                var sw = new StreamWriter("config.txt", false, Encoding.GetEncoding("Shift_JIS"));
                sw.WriteLine(file[0]);
                sw.Flush();
                sw.Close();
            }
            else
            {
                datadrop.Text = file[0] + "turiden.txtがあるディレクトリを選択してください";
            }
        }
    }
}
