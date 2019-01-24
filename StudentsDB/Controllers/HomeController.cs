using StudentsDB.Models.DB;
using StudentsDB.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsDB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentsViewModel svm = new StudentsViewModel();
            List<Student> students = svm.GetStudents();
            return View(students);
        }

        public ActionResult NewStudent()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult NewStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentsViewModel svm = new StudentsViewModel();
                svm.SaveNewRecord(student);

                return RedirectToAction("Index", "Home");
            }

            return View(student);
        }

        public ActionResult UpdateStudent(int id = 0)
        {
            if (id == 0) { return RedirectToAction("Index", "Home"); }
            StudentsViewModel svm = new StudentsViewModel();
            Student student = svm.GetStudentDetailsById(id);

            return View(student);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult UpdateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentsViewModel svm = new StudentsViewModel();
                svm.UpdateStudentDetails(student);

                return RedirectToAction("Index", "Home");
            }

            return View(student);
        }
    }
}