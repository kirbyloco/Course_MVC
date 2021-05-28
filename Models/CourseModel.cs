using System;
using System.ComponentModel.DataAnnotations;

namespace course_std.Models
{
    public class Course
    {
        [Display(Name = "課程ID")]
        public int Id { get; set; }

        [Display(Name = "課程名稱")]
        public string CourseName { get; set; }
        [Display(Name = "授課教師")]
        public string Teacher { get; set; }
        [Display(Name = "必選修")]
        public string Reqele { get; set; }
        [Display(Name = "上課時間")]
        public string Date { get; set; }
        [Display(Name = "學分")]
        public int Credit { get; set; }
        [Display(Name = "上課教室")]
        public string Classroom { get; set; }
        [Display(Name = "學制")]
        public string Academic { get; set; }
        [Display(Name = "科系")]
        public string Schoolsys { get; set; }
        [Display(Name = "年級")]
        public string Grade { get; set; }
    }
}
