using System;
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
    public partial class Form3 : Form
    {
        List<goods> goodslist;
        public Form3(List<Denpyou> den,string title)
        {
            InitializeComponent();
            Text = title+"のランキング";
            rank.Text = title+"のランキング";
            total(den);
            sortListnum();
            rankingNum();
            show();
        }
        public void total(List<Denpyou> list)
        {
            goodslist = new List<goods>();
            goods pg;
            foreach (Denpyou d in list)
            {
                if (d.line != null)
                {
                    foreach (goods g in d.line)
                    {
                        if (g.num > 0)
                        {
                            pg = goodslist.Find(delegate (goods s) { return s.name.Equals(g.name); });
                            if (pg == null)
                            {
                                goodslist.Add(new goods(g.name, g.num));
                            }
                            else
                            {
                                pg.num += g.num;
                            }
                        }
                    }
                }
            }
        }
        public void sortListnum()
        {
            goodslist.Sort((g1, g2) => g2.num - g1.num);
        }
        public void sortListname()
        {
            goodslist.Sort((g1,g2) => g1.name.CompareTo(g2.name));
        }
        public void show()
        {
            ranklistView.Items.Clear();
            for (int i = 0; i < goodslist.Count; i++)
            {
                ranklistView.Items.Add(new ListViewItem(new string[] {""+goodslist[i].value,goodslist[i].name,""+goodslist[i].num }));
            }
        }
        void rankingNum()
        {
            for (int i = 0; i < goodslist.Count; i++)
            {
                goodslist[i].value = i + 1;
            }
        }

        private void rankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortListnum();
            show();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortListname();
            show();
        }
    }

}
