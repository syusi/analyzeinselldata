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
    public partial class home : Form
    {
        string s;
        public home()
        {
            InitializeComponent();
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
            datadrop.Text = file[0]+"が選択されました";
            s = file[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(s, Encoding.GetEncoding("Shift_JIS"));

            string sline;
            int num=0;
            sline = sr.ReadLine();
            while (sline != null)
            {
                string[] sinfo = sline.Split('\t');
                /*analabel.Text = "データの個数は" + sinfo.Length + "個です\n";
                int i = 1;
                foreach (string de in sinfo)
                {
                    analabel.Text += i + "つめ" + de + "\n";
                    i++;
                }*/
                analabel.Text = ""+num++;
                listView1.Items.Add(new ListViewItem(sinfo));
                sline = sr.ReadLine();
            }
        }
    }
}
