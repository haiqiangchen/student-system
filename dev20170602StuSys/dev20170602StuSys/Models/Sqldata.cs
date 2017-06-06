using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dev20170602StuSys.Models
{
    public class Sqldata
    {
        DBManage DB = new DBManage();
        public Sqldata() {              
            DB.students.Add(new Student { Name = "jame", StuId = "201430",teacher="Mr wa", Password = "123", Chinese = 89, Math = 95, English = 99, Physics = 89 });
            DB.students.Add(new Student { Name = "har", StuId = "201432", teacher = "Mr wa", Password = "123", Chinese = 79, Math = 100, English = 90, Physics = 89});
            DB.students.Add(new Student { Name = "mark", StuId = "201431", teacher = "Mr wa", Password = "123", Chinese = 91, Math = 90, English = 89, Physics = 89 });
            DB.SaveChanges();
        }
    }
}