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

using Microsoft.AspNetCore.Identity;

namespace course_std.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly CourseContext _context;
        private readonly LogContext _logcontext;
        private readonly UserManager<IdentityUser> _userManager;

        public CourseController(CourseContext context, LogContext logcontext, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _logcontext = logcontext;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<ActionResult<Log>> Add(Log log)
        {
            _logcontext.Add(log);
            await _logcontext.SaveChangesAsync();
            return new OkObjectResult(200);
        }

        [HttpPost] // 刪除資料庫有問題
        public async Task<ActionResult<Log>> Drop(Log log)
        {
            // var logID = from m in _logcontext.Log where m.Courseid == log.Courseid & m.Username == log.Username select m.ID;
            var logID = from m in _logcontext.Log where m.Courseid == log.Courseid & m.Username == log.Username select m;
            foreach (Log data in logID)
            {
                _logcontext.Remove(data);
            }

            await _logcontext.SaveChangesAsync();
            return new OkObjectResult(200);
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
        public async Task<IActionResult> Result()
        {
            dynamic model = new ExpandoObject();

            var logdata = from log in _logcontext.Log where log.Username == _userManager.GetUserName(User) select log.Courseid;
            var logdata2 = await logdata.ToListAsync();
            var coursesdata = from m in _context.Course where logdata2.Contains(m.Id) select m;
            model.Course = await coursesdata.ToListAsync();

            return View(model);
        }

    }
}
