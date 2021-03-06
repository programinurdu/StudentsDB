﻿using System;
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
        [Display(Name = "Student Id:")]
        public int StudentId { get; set; }

        [Display(Name = "Full Name:")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Display(Name = "Mobile:")]
        public string Mobile { get; set; }

        [Display(Name = "Telephone:")]
        public string Telephone { get; set; }

        [Display(Name = "Notes:")]
        public string Notes { get; set; }
    }
}