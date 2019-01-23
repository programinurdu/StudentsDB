using StudentsDB.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsDB.ViewModels.Home
{
    public class StudentsViewModel
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (StudentsDBContext db = new StudentsDBContext())
            {
                students = db.Students.ToList();
            }

            return students;
        }
    }
}