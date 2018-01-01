using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sellanalyze
{
    public partial class Goodsrank : Form
    {
        List<ditaligoods> allGoods;
        List<ditaligoods> showGoods;
        bool isMonth;

        readonly double[] temperature;

        public Goodsrank(List<ditaligoods> g,double[] d)
        {
            InitializeComponent();
            allGoods = g;
            temperature = d;
            showGoods = new List<ditaligoods>();
            int sum = allGoods.Sum(dg=>dg.num);
            string yearText = temperature[0] == 0 ? "" : temperature[0] + "年度";
            Goodsnamelabel.Text = g[0].name + "の詳細(売り上げ"+allGoods.Count+"件 , 合計"+sum+"個)" + yearText;
            setViewtoMonth();
            isMonth = true;

        }
        private void setViewtoMonth()
        {
            divideShowToMonth();
            changeViewinmonth();
            addViewtoMonth();
            setMonthChart();
        }
        private void setViewtoStore()
        {
            divideShowToStore();
            changeViewinStore();
            SortShowGoods("store");
            addViewtoStore();
            setStoreChart();
        }
        private void changeViewinmonth()
        {
            goodsListView.Columns.Clear();

            goodsListView.Columns.Add(new ColumnHeader() { Text = "販売月", Width = 75 });
            goodsListView.Columns.Add(new ColumnHeader() { Text = "売り上げ個数", Width = 130});
            goodsListView.Columns.Add(new ColumnHeader() { Text = "気温", Width = 75 });
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
            int i = 1;
            foreach(ditaligoods dt in showGoods)
            {
                goodsListView.Items.Add(new ListViewItem(new string[] {""+dt.month,""+dt.num ,""+temperature[i]}));
                i++;
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
        private void setMonthChart()
        {
            //グラフについてはここ　https://qiita.com/hart_edsf/items/013479474090a4e681f3
            ChartControl.Series.Clear();

            Series monthgoods = new Series();
            Series tempGraph = new Series();
            int max = 0;

            monthgoods.ChartType = SeriesChartType.Column;

            tempGraph.ChartType = SeriesChartType.Line;
            tempGraph.BorderWidth = 3;
            foreach (ditaligoods dt in showGoods) 
            {
                monthgoods.Points.AddXY(dt.month, dt.num);
                max = Math.Max(max, dt.num);
            }
            for(int i = 1; i < temperature.Length; i++)
            {
                tempGraph.Points.AddXY(i,(temperature[i]/30*max));
            }
            ChartControl.Series.Add(monthgoods);
            ChartControl.Series.Add(tempGraph);
            Axis chart_x = ChartControl.ChartAreas[0].AxisX;
            //chart_x.Maximum = 13;//横の最大値最小値を変更
            //chart_x.Minimum = 0;
            chart_x.Title = "月";

            ChartControl.Titles[0].Text = "月別グラフ";
        }

        private void setStoreChart()
        {
            ChartControl.Series.Clear();

            Series storegoods = new Series();

            storegoods.ChartType = SeriesChartType.Column;
            storegoods.YValueType = ChartValueType.String;

            foreach(ditaligoods dt in showGoods)
            {
                storegoods.Points.AddXY(dt.storename, dt.num);
            }
            ChartControl.Series.Add(storegoods);
            Axis chart_x = ChartControl.ChartAreas[0].AxisX;

            chart_x.Title = "店名";
            //chart_x.LabelStyle.Angle = 90;
            ChartControl.Titles[0].Text = "店別グラフ";
        }
    }
}
