namespace LearnIt.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using LearnIt.Data;
    using LearnIt.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void BuildViewBag()
        {
            ViewBag.Courses = _context.Courses.ToList();
            var user = _context.Users
                .Where(x => x.UserName == this.User.Identity.Name)
                .Include(x => x.Courses)
                .SingleOrDefault();
            ViewBag.User = user;
            if(!(user is null))
            {
                var myCoursesIds = user.Courses.Select(x => x.CourseId).ToList();
                var myCourses = _context.Courses
                    .Where(x => myCoursesIds.Contains(x.Id))
                    .OrderByDescending(x => x.StartDate)
                    .ToList();
                ViewBag.MyCourses = myCourses;
            }
        }

        public IActionResult Index()
        {
            //Uncomment only if your database is empty and you want to populate it 
            //DatabasePopulator.Populate(_context);
            BuildViewBag();

            return View();
        }

        public IActionResult Course(string id)
        {
            BuildViewBag();
            var course = _context.Courses
                .Where(x => x.Id == id)
                .Include(x => x.Lectures)
                .FirstOrDefault();
            ViewBag.Course = course;
            ViewBag.Lectures = course.Lectures
                .OrderBy(x => x.StartDate)
                .ToList();

            return View();
        }

        public IActionResult AddCourse(string id)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == id);
            var user = _context.Users
                .Where(x => x.UserName == this.User.Identity.Name)
                .Include(x => x.Courses)
                .SingleOrDefault();
            bool isAlreadySigned = user.Courses
                .Select(x => x.CourseId)
                .Contains(id);
            if(!isAlreadySigned)
            {
                var connection = new UsersCoursesDataModel
                {
                    UserId = user.Id,
                    User = user,
                    CourseId = course.Id,
                    Course = course
                };
                _context.UsersCourses.Add(connection);
                user.Courses.Add(connection);
                course.Users.Add(connection);
                _context.SaveChanges();
            }

            BuildViewBag();
            course = _context.Courses
                .Where(x => x.Id == id)
                .Include(x => x.Lectures)
                .FirstOrDefault();
            ViewBag.Course = course;
            ViewBag.Lectures = course.Lectures
                .OrderBy(x => x.StartDate)
                .ToList();

            return RedirectToAction("Course", new { id = id });
        }

        public IActionResult AboutUs()
        {
            BuildViewBag();

            return View();
        }

        public IActionResult Contacts()
        {
            BuildViewBag();

            return View();
        }

        public IActionResult Video(string id)
        {
            BuildViewBag();
            var lecture = _context.Lectures
                .Where(x => x.Id == id)
                .Include(x => x.Course)
                .Include(x => x.Course.Lectures)
                .FirstOrDefault();
            ViewBag.Lecture = lecture;
            var course = lecture.Course;
            ViewBag.Course = course;
            ViewBag.Lectures = course.Lectures.OrderBy(x => x.StartDate).ToList();
            ViewBag.Index = ViewBag.Lectures.IndexOf(lecture);

            return View();
        }

        public IActionResult MyInfo()
        {
            BuildViewBag();

            if(ViewBag.User is null) return RedirectToAction("Index");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
