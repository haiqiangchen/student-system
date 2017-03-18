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
    public partial class Form1 : Form
    {
        LogsDB logDb = new LogsDB();
        public Form1()
        {
            InitializeComponent();
            new Initialize();

            update();
           

        }
        public void update() {
            foreach (var this_day in logDb.This_days)
            {
                if (this_day.Date_time == DateTime.Now.ToShortDateString())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = this_day.id.ToString();
                    item.SubItems.Add(this_day.Date_time);
                    item.SubItems.Add(this_day.Log);
                    listView1.Items.Add(item);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count!= 0){
                ListViewItem item = new ListViewItem();
                for (int i=0;i<=listView1.SelectedItems.Count;i++) {
                    item = listView1.SelectedItems[i];
                    listView1.Items.Remove(item);
                    int a = Convert.ToInt16(item.Text);
                   This_day[] day = logDb.This_days.SqlQuery("select *from This_day where id="+a).ToArray();
                    logDb.This_days.Remove(day[0]);
                    logDb.SaveChanges();
                }
            }
        }
    }
}
