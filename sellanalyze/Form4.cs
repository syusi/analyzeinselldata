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
    public partial class Goodsrank : Form
    {
        List<ditaligoods> allGoods;
        List<ditaligoods> showGoods;
        bool isMonth;
        public Goodsrank(List<ditaligoods> g)
        {
            InitializeComponent();
            allGoods = g;
            showGoods = new List<ditaligoods>();
            int sum = allGoods.Sum(dg=>dg.num);
            Goodsnamelabel.Text = g[0].name + "の詳細(売り上げ"+allGoods.Count+"件 , 合計"+sum+"個)";
            setViewtoMonth();
            isMonth = true;

        }
        private void setViewtoMonth()
        {
            divideShowToMonth();
            changeViewinmonth();
            addViewtoMonth();
        }
        private void setViewtoStore()
        {
            divideShowToStore();
            changeViewinStore();
            SortShowGoods("store");
            addViewtoStore();
        }
        private void changeViewinmonth()
        {
            goodsListView.Columns.Clear();

            goodsListView.Columns.Add(new ColumnHeader() { Text = "販売月", Width = 75 });
            goodsListView.Columns.Add(new ColumnHeader() { Text = "売り上げ個数", Width = 130});
        }
        private void changeViewinStore()
        {
            goodsListView.Columns.Clear();

            goodsListView.Columns.Add(new ColumnHeader() {Text="販売店",Width=200 });
            goodsListView.Columns.Add(new ColumnHeader() {Text="売り上げ個数",Width=130 });
        }

        private void monthMenuItem_Click(object sender, EventArgs e)
        {
            setViewtoMonth();
            isMonth = true;
        }

        private void storeMenuItem_Click(object sender, EventArgs e)
        {
            setViewtoStore();
            isMonth = false;
        }
        private void divideShowToMonth()
        {
            showGoods.Clear();
            ditaligoods[] dgoodsTomonth = new ditaligoods[12];
            for (int i = 0; i < 12; i++)
            {
                dgoodsTomonth[i] = new ditaligoods(allGoods[0].name, 0, (i+1), "");
            }
            foreach (ditaligoods dt in allGoods)
            {
                dgoodsTomonth[dt.month-1].num += dt.num;
            }
            showGoods.AddRange(dgoodsTomonth);
        }
        private void divideShowToStore()
        {
            showGoods.Clear();
            foreach(ditaligoods dtgoods in allGoods)
            {
                ditaligoods d = showGoods.Find(g=>g.storename.Equals(dtgoods.storename));
                if (d != null)
                {
                    d.num += dtgoods.num;
                }
                else
                {
                    d = new ditaligoods(dtgoods.name, dtgoods.num, 0, dtgoods.storename);
                    showGoods.Add(d);
                }
            }
        }
        private void addViewtoMonth()
        {
            goodsListView.Items.Clear();
            foreach(ditaligoods dt in showGoods)
            {
                goodsListView.Items.Add(new ListViewItem(new string[] {""+dt.month,""+dt.num }));
            }
        }
        private void addViewtoStore()
        {
            goodsListView.Items.Clear();
            foreach (ditaligoods dt in showGoods)
            {
                goodsListView.Items.Add(new ListViewItem(new string[] { dt.storename, "" + dt.num }));
            }
        }
        private void SortShowGoods(string sort)
        {
            if (sort.Equals("month"))
                showGoods.Sort((g1, g2) => g1.month - g2.month);
            if (sort.Equals("store"))
                showGoods.Sort((g1, g2) => g1.storename.CompareTo(g2.storename));
            if (sort.Equals("num"))
                showGoods.Sort((g1,g2)=>g2.num-g1.num);
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isMonth)
            {
                SortShowGoods("month");
                addViewtoMonth();
            }
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isMonth == false)
            {
                SortShowGoods("store");
                addViewtoStore();
            }
        }

        private void numToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortShowGoods("num");
            if (isMonth)
                addViewtoMonth();
            else
                addViewtoStore();
        }
    }
}
