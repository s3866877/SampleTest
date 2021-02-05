using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SampleTest.Data;

namespace SampleTest.Controllers
{
    public class InstructorController : Controller
    {
        private readonly SampleContext _context;

        public InstructorController(SampleContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var instructors = await _context.Instructors.ToListAsync();
            return View(instructors);
        }

        public IActionResult ViewCourses()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
