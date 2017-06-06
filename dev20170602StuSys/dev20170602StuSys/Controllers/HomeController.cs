using dev20170602StuSys.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dev20170602StuSys.Controllers
{
    public class HomeController : Controller
    {
       DBManage DB = new DBManage();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //这里显示学生的成绩信息
        public ActionResult Borrow()
        {
            var students = DB.students.SqlQuery("select *from Students ").ToList();
            sorting();
            return View(students);
        }
        [HttpPost]
        public ActionResult BorrOw(FormCollection formcollection) {
            if (ModelState.IsValid) {
                ViewData["Sorting"] = new SelectList("SortingName");
                string SortingName= formcollection["Sorting"].ToString();
                SortingName=Process(SortingName);
                var student = DB.students.SqlQuery("select *from Students order by'"+ SortingName+"'" +"desc");
                sorting();
                return View(student);
            }
            return View();
        }
        //添加學生的信息
        public ActionResult Create() {
            return View();
        }
        //按键触发事件
        [HttpPost]
        public ActionResult Create(Student student) {
            if (ModelState.IsValid)
            {
                DB.students.Add(student);
                DB.SaveChanges();
                return RedirectToAction("Borrow");
            }
            return View();
        }
        //编辑学生信息
        public ActionResult Edit(int Id) {
            var student = DB.students.Find(Id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student) {
            if (ModelState.IsValid) {
                DB.Entry(student).State = EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("Borrow");
            }
            return View();
        }
        //删除学生的信息
        public ActionResult Delete(int Id) {
            var student = DB.students.Find(Id);
            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteName(int Id)
        {
            Student student = DB.students.Find(Id);
            DB.students.Remove(student);
            DB.SaveChanges();
            return RedirectToAction("Borrow");
        }
        //对排序的控件进行定义传送
        public void sorting() {
            List<string> list1 = new List<string> { "按语文成绩排序", "按数学成绩排序", "按英语成绩排序", "按物理成绩排序", "按平均分排序", "按总分排序" };
            SelectList select1 = new SelectList(list1, list1);
            ViewBag.selList1 = select1.AsEnumerable();
        }
        //对view传回的值进行相应的处理
        public string Process(string SortingName) {
            if (SortingName == "按语文成绩排序") {
                SortingName = "Chinese";
            } else if (SortingName == "按数学成绩排序") {
                SortingName = "Math";
            } else if (SortingName == "按英语成绩排序") {
                SortingName = "English";
            } else if (SortingName == "按物理成绩排序") {
                SortingName = "Physics";
            } else if (SortingName == "按平均分排序") {
                SortingName = "mean";
            } else {
                SortingName = "total";
            }
            return SortingName;
        }
    }
}