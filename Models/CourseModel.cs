using System;
using System.ComponentModel.DataAnnotations;

namespace course_std.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public string Reqele { get; set; }
        public string Date { get; set; }
        public int Credit { get; set; }
        public string Classroom { get; set; }
    }
}
