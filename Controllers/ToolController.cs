using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using course_std.Data;
using course_std.Models;

namespace course_std.Controllers
{
    public class ToolController : Controller
    {
        private readonly CreditsContext _context;

        public ToolController(CreditsContext context)
        {
            _context = context;
        }



        public IActionResult CourseTime()
        {
            return View();
        }
        public async Task<IActionResult> Credits(string academic, string schoolsys)
        {
            // ViewData.Add()
            dynamic model = new ExpandoObject();
            var credits = from m in _context.Credits select m;

            if (!String.IsNullOrEmpty(academic) & !String.IsNullOrEmpty(schoolsys))
            {
                credits = credits.Where(s => s.Academic.Contains(academic));
                credits = credits.Where(s => s.Schoolsys.Contains(schoolsys));
            }
            else
            {
                credits = credits.Where(s => s.Academic.Contains("NULL"));
                credits = credits.Where(s => s.Schoolsys.Contains("NULL"));
            }

            model.Academic = academic;
            model.Schoolsys = schoolsys;
            model.Credits = await credits.ToListAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
