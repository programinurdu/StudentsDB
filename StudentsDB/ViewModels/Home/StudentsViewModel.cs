﻿using StudentsDB.Models.DB;
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

        public List<Student> FindStudent(string searchterm)
        {
            List<Student> students = new List<Student>();

            using (StudentsDBContext db = new StudentsDBContext())
            {
                students = db.Students.Where(x => x.FullName.Contains(searchterm)).ToList();
            }

            return students;
        }

        public Student GetStudentDetailsById(int id)
        {
            Student student = new Student();

            using (StudentsDBContext db = new StudentsDBContext())
            {
                student = db.Students.Where(x => x.StudentId == id).FirstOrDefault();
            }

            return student;
        }

        public void UpdateStudentDetails(Student student)
        {
            using (StudentsDBContext db = new StudentsDBContext())
            {
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (StudentsDBContext db = new StudentsDBContext())
            {
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }
    }
}