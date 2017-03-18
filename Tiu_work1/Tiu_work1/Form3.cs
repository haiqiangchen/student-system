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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public object Messagebox { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            LogsDB log = new LogsDB();
            log.This_days.Add(new This_day { Log = textBox1.Text, Date_time = DateTime.Now.ToShortDateString() });
            log.SaveChanges();
            MessageBox.Show("添加成功");
            textBox1.Text = "";
            this.Close();
        }
    }
}
