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

        public void SaveNewRecord(Student student)
        {
            using (StudentsDBContext db = new StudentsDBContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}