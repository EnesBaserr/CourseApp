﻿using System.Diagnostics.CodeAnalysis;

namespace CourseApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Course> Courses { get; set; }


    }
}
