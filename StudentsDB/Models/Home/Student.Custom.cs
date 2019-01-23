using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsDB.Models.DB
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
    }

    public class StudentMetaData
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Notes { get; set; }
    }
}