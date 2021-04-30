using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using course_std.Data;
using course_std.Models;

namespace course_std.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly CourseContext _context;

        public CourseController(CourseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Addrop(string academic, string schoolsys, string grade)
        {
            dynamic model = new ExpandoObject();
            model.Academic = academic;
            model.Schoolsys = schoolsys;
            model.Grade = grade;
            var courses = from m in _context.Course select m;
            if (!String.IsNullOrEmpty(academic) & !String.IsNullOrEmpty(schoolsys) & !String.IsNullOrEmpty(grade))
            {
                courses = courses.Where(s => s.Academic.Contains(academic));
                courses = courses.Where(s => s.Schoolsys.Contains(schoolsys));
                courses = courses.Where(s => s.Grade.Contains(grade));
            }

            model.Course = await courses.ToListAsync();

            return View(model);
        }
        public IActionResult Result()
        {
            return View();
        }

    }
}
