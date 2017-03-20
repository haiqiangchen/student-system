using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiu_work1
{
    public partial class Form2 : Form
    {
        LogsDB logDb = new LogsDB();
        public Form2()
        {
            InitializeComponent();
            List<This_day> Logs = logDb.This_days.SqlQuery("select *from This_day where Date_time!='" + DateTime.Now.Date.ToShortDateString()
                      + "'order by Date_time ").ToList();
            foreach (var Re in Logs)
            {
                Logs ll = new Logs();
                ll.Date_time = Re.Date_time;
                ll.Log = Re.Log;
                logDb.Logs.Add(ll);
                logDb.SaveChanges();
            }
            foreach (var log in logDb.Logs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = log.id.ToString();
                item.SubItems.Add(log.Date_time);
                item.SubItems.Add(log.Log);
                listView1.Items.Add(item);
            }
          
        }
        /*
           显示一周内的记录
            */
        private void button1_Click(object sender, EventArgs e)
        {
            List<Logs> logs = logDb.Logs.SqlQuery("select *from Logs where Date_time >'"+ DateTime.Now.AddDays(-7).ToShortDateString() + "'order by Date_time desc ").ToList();
            listView1.Items.Clear();
            Weekupdate(logs);
            

        }
        /*
        显示两周内的记录
            */

        private void button2_Click(object sender, EventArgs e)
        {
            List<Logs> logs = logDb.Logs.SqlQuery("select *from Logs where Date_time >'" + DateTime.Now.AddDays(-14).ToShortDateString() + "'order by Date_time desc").ToList();
            listView1.Items.Clear();
            Weekupdate(logs);
        }
        /*
              显示一个月内的记录 
            */
        private void button3_Click(object sender, EventArgs e)
        {
            List<Logs> logs = logDb.Logs.SqlQuery("select *from Logs where Date_time >'" + DateTime.Now.AddDays(-30).ToShortDateString() + "'order by Date_time desc").ToList();
            listView1.Items.Clear();
            Weekupdate(logs);

        }
    
        /*
            编写将数据读入listview的表格，刷新表格
            */
        public void Weekupdate(List<Logs> this_weeks)
        {
            int i = 1;
            foreach (var this_day in this_weeks)
            {

                ListViewItem item = new ListViewItem();
                item.Text = (i++).ToString();
                item.SubItems.Add(this_day.Date_time);
                item.SubItems.Add(this_day.Log);
                listView1.Items.Add(item);

            }
        }
    }
}
