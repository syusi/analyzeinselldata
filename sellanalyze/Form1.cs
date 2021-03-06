﻿using System;
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
        string recentday;
        string oldday;
        List<Denpyou> denpyou = new List<Denpyou>();
        List<string> goodsnamelist = new List<string>();
        public home()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isUpgrade == false)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.isUpgrade = true;
                if (Properties.Settings.Default.Datapath.Equals(""))
                {
                    newFileOpen();
                }
            }
            var dt = DateTime.Now;
            newtimerange.Value = dt;
            oldtimerange.Value = new DateTime(dt.Year - 3, dt.Month, dt.Day);
            recentday = nowaday(dt.Year, dt.Month, dt.Day);
            oldday = nowaday(dt.Year - 3, dt.Month, dt.Day);

            importgoods();
            goodslistset("");
        }
        private void newFileOpen()
        {
            var f = new Form2();
            f.ShowDialog(this);
            f.Dispose();
        }
        private void importgoods()
        {
            var path = Properties.Settings.Default.Datapath;
            var shosr = new StreamReader(path + @"\mshohin.txt", Encoding.GetEncoding("Shift_JIS"));
            string[] sholine;

            sholine = readAndSplit(shosr);
            while (sholine != null)
            {
                goodsnamelist.Add(sholine[2]);
                sholine = readAndSplit(shosr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denpyou.Clear();
            storeBox.Items.Clear();
            GoodsYearBox.Items.Clear();
            var path = Properties.Settings.Default.Datapath;
            var densr = new StreamReader(path + @"\turiden.txt", Encoding.GetEncoding("Shift_JIS"));// 伝票の情報
            var meisr = new StreamReader(path + @"\turimei.txt", Encoding.GetEncoding("Shift_JIS"));// 伝票の明細
            var stosr = new StreamReader(path + @"\mtokui.txt", Encoding.GetEncoding("Shift_JIS"));// 得意先の情報

            readber.Value = 0;
            readber.Visible = true;
            readber.Maximum = File.ReadAllLines(path + @"\turiden.txt", Encoding.GetEncoding("Shift_JIS")).Length;

            string[] denline;
            string[] meiline;
            string[] stoline;

            List<Store> allStore = new List<Store>();
            stoline = readAndSplit(stosr);
            while (stoline != null)
            {
                allStore.Add(new Store(stoline));
                stoline = readAndSplit(stosr);
            }
            Denpyou de;
            List<goods> glist = new List<goods>();
            denline = readAndSplit(densr);
            meiline = readAndSplit(meisr);
            while (denline != null)
            {
                if (denline[3].Substring(0, 10).CompareTo(recentday) > 0 || denline[3].Substring(0, 10).CompareTo(oldday) < 0)
                {
                    denline = readAndSplit(densr);
                    readber.PerformStep();
                    continue;
                }
                de = new Denpyou(denline);
                while (meiline != null && !denline[0].Equals(meiline[0]))
                {
                    meiline = readAndSplit(meisr);
                }
                while (meiline != null && de.denNO.Equals(meiline[0]))
                {
                    glist.Add(new goods(meiline));
                    meiline = readAndSplit(meisr);
                }
                de.line = glist.ToArray();
                de.storename = allStore.Find(delegate (Store s) { return s.number.Equals(de.storenumber); }).name;
                denpyou.Add(de);
                glist.Clear();
                denline = readAndSplit(densr);
                readber.PerformStep();
            }
            if (denpyou.Count() <= 0)
            {
                analabel.Text = "データが存在しません";
            }
            else
            {
                if (File.Exists(path + @"\displaytokui.txt"))
                {
                    stosr = new StreamReader(path + @"\displaytokui.txt", Encoding.GetEncoding("Shift_JIS"));
                    allStore.Clear();
                    stoline = readAndSplit(stosr);
                    while (stoline != null)
                    {
                        allStore.Add(new Store(stoline));
                        stoline = readAndSplit(stosr);
                    }
                }
                storeBox.Items.Add(new Store("高知植木鉢センター", "0"));
                foreach (Store onestore in allStore)
                {
                    if (!string.IsNullOrWhiteSpace(onestore.name))
                        storeBox.Items.Add(onestore);
                }
                changeview(denpyou[0]);
                updownbutton.Value = 0;
                updownbutton.Maximum = denpyou.Count - 1;

                GoodsYearBox.Items.Add("全ての年");
                for(int i=oldtimerange.Value.Year; i<= newtimerange.Value.Year; i++)
                {
                    GoodsYearBox.Items.Add(i + "");
                }
                GoodsYearBox.SelectedIndex = 0;
                readber.Visible = false;
            }

        }
        private void anatextwrite(string[] s)
        {
            analabel.Text = "データの個数は" + s.Length + "個です\n";
            int i = 0;
            foreach (string info in s)
            {
                analabel.Text += i + "つめ" + info + "\n";
                i++;
            }
        }
        private string[] readAndSplit(StreamReader sr)
        {
            string line = sr.ReadLine();
            if (line == null)
                return null;
            return line.Split('\t');
        }
        private void changeview(Denpyou d)
        {
            denlist.Items.Clear();
            analabel.Text = d.reinfo();
            var list = d.relinelist();
            foreach (string[] l in list)
            {
                denlist.Items.Add(new ListViewItem(l));
            }
        }
        private void pathchangemenu_Click(object sender, EventArgs e)
        {
            newFileOpen();
        }
        private string nowaday(int y, int m, int d)
        {
            var dt = new DateTime(y, m, d);
            string day = dt.ToString("u");
            return day.Substring(0, 10);
        }

        private void updownbutton_ValueChanged(object sender, EventArgs e)
        {
            if (denpyou.Count > 0)
                changeview(denpyou[decimal.ToInt32(updownbutton.Value)]);
            else
                analabel.Text = "分析を行ってください";
        }

        private void manthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (denpyou.Count() != 0)
            {
                int selectmonth = manthBox.SelectedIndex + 1;
                var selected = from d in denpyou
                               where d.month == selectmonth
                               select d;
                if (selected.Count() != 0)
                {
                    Form3 f3 = new Form3(selected.ToList(), manthBox.Text, this);
                    f3.Show();
                }
                else
                    analabel.Text = "該当するデータがありません";
            }
            else
            {
                analabel.Text = "分析を行ってください";
            }
        }

        private void oldtimerange_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = oldtimerange.Value;
            oldday = nowaday(d.Year, d.Month, d.Day);
        }

        private void newtimerange_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = newtimerange.Value;
            recentday = nowaday(d.Year, d.Month, d.Day);
        }

        private void storeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (denpyou.Count() != 0)
            {
                string selectstore = ((Store)storeBox.SelectedItem).number;
                if (selectstore.Equals("0"))
                {
                    Form3 f3 = new Form3(denpyou, storeBox.Text, this);
                    f3.Show();
                }
                else
                {
                    var selected = from d in denpyou
                                   where d.storenumber.Equals(selectstore)
                                   select d;
                    if (selected.Count() != 0)
                    {
                        Form3 f3 = new Form3(selected.ToList(), storeBox.Text, this);
                        f3.Show();
                    }
                    else
                        analabel.Text = "該当するデータがありません";
                }
            }
            else
            {
                analabel.Text = "分析を行ってください";
            }
        }
        private void goodslistset(string name)
        {
            var exgoodsname = goodsnamelist.Where(g => g.Contains(name));
            foreach (string s in exgoodsname)
            {
                goodsnamebox.Items.Add(s);
            }
        }

        public void setgoodstext(string s)
        {
            goodsTextbox.Text = s;
        }

        private void goodsnamebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setgoodstext((string)goodsnamebox.SelectedItem);
        }

        private void goodssendButton_Click(object sender, EventArgs e)
        {
            List<ditaligoods> dtgoods = new List<ditaligoods>();
            int year = 0;
            if (GoodsYearBox.SelectedIndex != 0)
            {
                year = int.Parse((string)GoodsYearBox.SelectedItem);
            }
            
            foreach(Denpyou d in denpyou)
            {
                if(year != 0 && d.year != year)
                {
                    continue;
                }
                ditaligoods dg = d.existgoods(goodsTextbox.Text);
                if (dg != null)
                    dtgoods.Add(dg);
            }
            if (dtgoods.Count > 0)
            {
                var path = Properties.Settings.Default.Datapath;
                var tempSt = new StreamReader(path + @"\templature.txt", Encoding.GetEncoding("Shift_JIS"));
                double[] tempnum = new double[13];
                if(year != 0)
                {
                    string[] t = readAndSplit(tempSt);
                    while (!t[0].Equals(year.ToString()))//年数が同じになるまでまわす。
                    {
                        t = readAndSplit(tempSt);
                    }
                    for(int i = 0; i < tempnum.Length; i++)
                    {
                        tempnum[i] = double.Parse(t[i]);
                    }
                }
                else
                {
                    tempnum[0] = 0;
                }
                Goodsrank gr = new Goodsrank(dtgoods,tempnum);
                gr.Show();
            }
            else
            {
                analabel.Text = "該当する商品が見つかりません";
            }
        }

        private void denlist_ItemActivate(object sender, EventArgs e)
        {
            //意図していなかったが、項目のダブルクリックでこのイベントが発生するらしい
            var item = ((ListView)sender).SelectedItems[0]; //最初に選択された物を取得
            this.setgoodstext(item.Text);
        }
    }
    public class goods
    {
        public string name { get; set; }
        public int num { get; set; }
        public int value { get; set; }
        public goods(string[] line)
        {
            name = line[4];
            num = (int)double.Parse(line[8]);
            value = (int)double.Parse(line[11]);
        }
        public goods(string n, int i)
        {
            this.name = n;
            this.num = i;
        }
        public string data()
        {
            return name + " @ " + value + "円 : " + num + "個\n";
        }
        public string[] listoutput()
        {
            return new string[] { name, value.ToString(), num.ToString() };
        }

    }
    public class ditaligoods : goods
    {
        public string storename { get; }
        public int month { get; }
        public ditaligoods(goods g,string stname,int m):base(g.name,g.num)
        {
            storename = stname;
            month = m;
        }
        public ditaligoods(string n,int num,int m,string s):base(n,num)
        {
            storename = s;
            month = m;
        }
        
    }
    public class Store
    {
        public string number { get; set; }
        public string name { get; set; }
        public Store(string[] s)
        {
            this.number = s[0];
            this.name = s[4];
        }
        public Store(string name, string num)
        {
            this.number = num;
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
    public class Denpyou
    {
        public Denpyou(string[] line)
        {
            this.denNO = line[0];
            inputday(line[3]);
            storenumber = line[4];
        }
        public string denNO { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public string storenumber { get; set; }
        public string storename { get; set; }
        public goods[] line { get; set; }

        public void inputday(string d)
        {
            year = int.Parse(d.Substring(0, 4));
            month = int.Parse(d.Substring(5, 2));
            day = int.Parse(d.Substring(8, 2));
        }
        public string reday()
        {
            var dt = new DateTime(year, month, day);
            string days = dt.ToString("u");
            return days.Substring(0, 10);
        }
        public string reinfo()
        {
            var info = denNO + " 日時 : " + reday() + " 取引先 : " + storename + "\n";
            return info;
        }
        public ditaligoods existgoods(string gname)
        {
            foreach (goods s in line)
            {
                if (s.name.Equals(gname))
                {
                    return new ditaligoods(s,this.storename,this.month);
                }
            }
            return null;
        }
        public string[][] relinelist()
        {
            var linelist = new string[line.Count()][];
            for (int i = 0; i < line.Count(); i++)
                linelist[i] = line[i].listoutput();
            return linelist;
        }
    }
}
