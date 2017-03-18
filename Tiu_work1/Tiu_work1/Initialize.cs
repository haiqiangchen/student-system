using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiu_work1
{
    class Initialize
    {
        LogsDB logsDb = new LogsDB();

        public Initialize()
        {
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });//匿名类对数据库进行赋值
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.Date.ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.AddDays(-1).ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.AddDays(-2).ToShortDateString() });
            logsDb.This_days.Add(new This_day { Log = "今天天气好", Date_time = DateTime.Now.AddDays(-3).ToShortDateString() });
            logsDb.SaveChanges();//数据库保存
        }
         
           

        }
    }
