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
    }
}