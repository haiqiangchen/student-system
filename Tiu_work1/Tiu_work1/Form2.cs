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
            List<This_day> Logs = logDb.This_days.SqlQuery("select *from This_day where Date_time!='" + DateTime.Now.Date.ToShortDateString() +"'").ToList();
            foreach (var Re in  Logs) {
                Logs ll = new Logs();
                ll.Date_time = Re.Date_time;
                ll.Log = Re.Log;
                logDb.Logs.Add(ll);
                logDb.This_days.Remove(Re);
                logDb.SaveChanges();
            }
            foreach (var log in logDb.Logs) {
                ListViewItem item = new ListViewItem();
                item.Text = log.id.ToString();
                item.SubItems.Add(log.Date_time);
                item.SubItems.Add(log.Log);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
