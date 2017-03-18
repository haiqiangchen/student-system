using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiu_work1
{
    public class LogsDB : DbContext  //继承DBContext接口的类
    {
        public LogsDB() //构造方法
        {
            Database.SetInitializer<LogsDB>(new DropCreateDatabaseAlways<LogsDB>());//清空数据库
        }
        public DbSet<Logs> Logs { set; get; }   //复写
        public DbSet<This_day> This_days { set; get; }
        public DbSet<This_week> This_weeks { set; get; }

    }
}
