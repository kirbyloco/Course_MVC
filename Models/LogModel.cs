using System;
using System.ComponentModel.DataAnnotations;

namespace course_std.Models
{
    public class Log
    {
        public int ID { get; set; }
        [Display(Name = "課程ID")]
        public int Courseid { get; set; }

        [Display(Name = "學號")]
        public string Username { get; set; }

    }
}
