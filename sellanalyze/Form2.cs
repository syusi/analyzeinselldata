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
            filepath = Properties.Settings.Default.Datapath;
            if (filepath.Equals(""))
            {
                datadrop.Text = "データが入っているディレクトリを選択してください";
            }
            else
            {
                datadrop.Text = "現在のディレクトリは\n" + filepath + "です";
            }
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
                Properties.Settings.Default.Datapath = file[0];
                Properties.Settings.Default.Save();
            }
            else
            {
                datadrop.Text = file[0] + "turiden.txtがあるディレクトリを選択してください";
            }
        }
    }
}
