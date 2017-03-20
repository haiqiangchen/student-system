using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tiu_work1
{
    public class  Logs
    {
        [Key]
        public int id { set; get; }
        public string Date_time { set; get; }
        public string Log { set; get; }
    }
    public class This_week {
        [Key]
        public int id { set; get; }
        public int week_id { set; get; }
        public string Date_time { set; get; }
        public string Log { set; get; }
    }
   public class This_day
    {
        [Key]
        public int id { set; get; }
        public string Date_time { set; get; }
        public string Log { set; get; }
    }

}
