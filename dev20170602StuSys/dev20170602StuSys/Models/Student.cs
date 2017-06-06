using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dev20170602StuSys.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="学生名字为必填项")]
        [StringLength(7)]
        public string Name { get; set; }
        [Required(ErrorMessage = "学生任课老师为必填项")]
        public string teacher { set; get; }
        [Required(ErrorMessage = "学生学号为必填项")]
        public string StuId { get; set; }
        public string Password { get; set; }
        [Range(0,100,ErrorMessage ="分数的范围是0到100分")]
        public int Chinese { get; set; }
        [Range(0, 100, ErrorMessage = "分数的范围是0到100分")]
        public int Math { get; set; }
        [Range(0, 100, ErrorMessage = "分数的范围是0到100分")]
        public int English { get; set; }
        [Range(0, 100, ErrorMessage = "分数的范围是0到100分")]
        public int Physics { get; set; }
        public int total { get {
                return Chinese + Math + English + Physics;
            } set { } }
        [Range(0, 100, ErrorMessage = "分数的范围是0到100分")]
        public int mean { get {
                return (Chinese + Math + English + Physics)/4;
            } set { } }
    }
}