using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace course_std.Models
{
    [Keyless]
    public class Credits
    {

        [Display(Name = "學制")]
        public string Academic { get; set; }
        [Display(Name = "科系")]
        public string Schoolsys { get; set; }
        [Display(Name = "畢業學分")]
        public string GraduationCredits { get; set; }
        [Display(Name = "通識學分")]
        public string GeneralCredits { get; set; }
        [Display(Name = "必修學分")]
        public string RequiredCredits { get; set; }
        [Display(Name = "選修學分")]
        public string ElectiveCredits { get; set; }

    }
}
