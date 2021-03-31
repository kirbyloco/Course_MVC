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

        public async Task<IActionResult> Addrop()
        {
            dynamic model = new ExpandoObject();
            model.Course = await _context.Course.ToListAsync();
            return View(model);
        }
        public IActionResult Result()
        {
            return View();
        }

    }
}
