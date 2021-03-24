using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using course_std.Models;

namespace course_std.Controllers
{
    public class ToolController : Controller
    {
        private readonly ILogger<ToolController> _logger;

        public ToolController(ILogger<ToolController> logger)
        {
            _logger = logger;
        }

        public IActionResult CourseTime()
        {
            return View();
        }
        public IActionResult Credits()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
