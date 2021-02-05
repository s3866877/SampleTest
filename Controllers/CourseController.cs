using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SampleTest.Data;

namespace SampleTest.Controllers
{
    public class CourseController : Controller
    {
        private readonly SampleContext _context;

        public CourseController(SampleContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToList();
            return View(courses);
        }

        public IActionResult ViewStudents()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
