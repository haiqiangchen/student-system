using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dev20170602StuSys.Models
{
    public class DBManage:DbContext
    {
        public DBManage() {
            Database.SetInitializer<DBManage>(new DropCreateDatabaseAlways<DBManage>());//清空数据库
        }
        public DbSet<Student> students { set; get; }
        public DbSet<Teacher> teacher  { set; get; }
    }
}