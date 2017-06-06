using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dev20170602StuSys.Models
{
    public class Teacher
    {
        [Key]
        public int Id { set; get; }
        public string Password { set; get; }
        public Student students { set; get; }
    }
}