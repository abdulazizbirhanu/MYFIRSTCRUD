using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentMGMT.Models;

namespace StudentMGMT.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            List<StudentModel> list = db.Students.Where(s => s.Id == id).ToList();
            return View(list);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            try
            {
                StudentModel studentlist = new StudentModel() { Id = model.Id, StudentId = model.StudentId, StudentName = model.StudentName, Age = model.Age, Sex = model.Sex, School = model.School, Batch = model.Batch };
                db.Students.Add(studentlist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            List<StudentModel> list = db.Students.Where(s => s.Id == id).ToList();
            return View(list);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudentModel model)
        {
            try
            {
                db.Students.Where(s => s.Id == id).ToList().ForEach(s => s=model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            List<StudentModel> list = db.Students.Where(s => s.Id == id).ToList();
            return View(list);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StudentModel model)
        {
            try
            {
                StudentModel student = new StudentModel() { Id = model.Id, StudentId = model.StudentId, StudentName = model.StudentName, Age = model.Age, Sex = model.Sex, School = model.School, Batch = model.Batch };
                db.Students.Remove(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
