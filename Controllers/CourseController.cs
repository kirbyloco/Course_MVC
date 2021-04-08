using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using course_std.Data;
using course_std.Models;

namespace course_std.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseContext _context;

        public CourseController(CourseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Addrop(string academic, string schoolsys, string grade)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("academic", academic);
            data.Add("schoolsys", schoolsys);
            data.Add("grade", grade);
            dynamic model = new ExpandoObject();
            model.Course = await _context.Course.ToListAsync();
            model.Data = data;
            return View(model);
        }
        public IActionResult Result()
        {
            return View();
        }

    }
}
