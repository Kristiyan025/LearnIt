namespace LearnIt.Controllers
{
    using LearnIt.Data;
    using LearnIt.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class CourseController : Controller
    {
        private readonly ILogger<LectureController> _logger;
        private ApplicationDbContext _context;

        public CourseController(ILogger<LectureController> logger, ApplicationDbContext context)
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
            if (!(user is null))
            {
                var myCoursesIds = user.Courses.Select(x => x.CourseId).ToList();
                var myCourses = _context.Courses
                    .Where(x => myCoursesIds.Contains(x.Id))
                    .OrderByDescending(x => x.StartDate)
                    .ToList();
                ViewBag.MyCourses = myCourses;
            }
        }

        [BindProperty]
        public FormModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class FormModel
        {
            [Display(Name = "Name:")]
            public string Name { get; set; }

            [Display(Name = "Course's Image Link:")]
            public string CourseImageLink { get; set; }

            [Display(Name = "About:")]
            public string About { get; set; }

            public string CourseId { get; set; }
        }

        public IActionResult EditCourse(string id)
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            ViewBag.Course = _context.Courses.FirstOrDefault(x => x.Id == id);
            return View("EditCourse", Input);
        }

        [HttpPost]
        public IActionResult UpdateCourse()
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            var course = _context.Courses.FirstOrDefault(x => x.Id == Input.CourseId);
            ViewBag.Course = course;
            if (ModelState.IsValid)
            {
                Dictionary<string, string> errs;
                if (isValidInput(out errs))
                {
                    //Name
                    if (Input.Name != "")
                    {
                        course.Name = Input.Name;
                    }
                    //PresentationLink
                    if (Input.CourseImageLink != "")
                    {
                        course.CourseImageLink = Input.CourseImageLink;
                    }
                    //About
                    if (Input.About != "" && Input.About.Length <= 5000)
                    {
                        course.About = Input.About;
                    }

                    _context.SaveChanges();
                    return RedirectToAction("Course", "Home", new { id = Input.CourseId });
                }
                else
                {
                    foreach (var err in errs)
                    {
                        ModelState.AddModelError(err.Key, err.Value);
                    }

                    return View("EditCourse");
                }
            }

            // If we got this far, something failed, redisplay form
            return View("EditCourse");
        }

        public IActionResult AddCourse()
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            return View("AddCourse", Input);
        }

        [HttpPost]
        public IActionResult AddCourseOnPost()
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                Dictionary<string, string> errs;
                if (isValidInput(out errs))
                {
                    CourseDataModel course = new CourseDataModel();
                    course.Id = Guid.NewGuid().ToString();
                    //Name
                    if (Input.Name != "")
                    {
                        course.Name = Input.Name;
                    }
                    //PresentationLink
                    if (Input.CourseImageLink != "")
                    {
                        course.CourseImageLink = Input.CourseImageLink;
                    }
                    //About
                    if (Input.About != "" && Input.About.Length <= 5000)
                    {
                        course.About = Input.About;
                    }

                    _context.Courses.Add(course);
                    _context.SaveChanges();
                    return RedirectToAction("Course", "Home", new { id = course.Id });
                }
                else
                {
                    foreach (var err in errs)
                    {
                        ModelState.AddModelError(err.Key, err.Value);
                    }

                    return View("AddCourse");
                }
            }

            // If we got this far, something failed, redisplay form
            return View("AddCourse");
        }

        public IActionResult DeleteCourse(string id)
        {
            var course = _context.Courses
                .Where(x => x.Id == id)
                .Include(x => x.Lectures)
                .Include(x => x.Users)
                .FirstOrDefault();
            if (course is null) return RedirectToAction("Index", "Home");

            _context.Lectures.RemoveRange(course.Lectures);
            var userCourses = course.Users.ToArray();
            foreach(var userCourse in userCourses)
            {
                var user = _context.Users
                    .Where(x => x.Id == userCourse.UserId)
                    .Include(x => x.Courses)
                    .FirstOrDefault();
                user.Courses.Remove(userCourse);
                course.Users.Remove(userCourse);
                _context.UsersCourses.Remove(userCourse);
            }

            _context.Courses.Remove(course);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private bool isValidInput(out Dictionary<string, string> errs)
        {
            bool isValid = true;
            errs = new Dictionary<string, string>();
            //Name
            Input.Name = Input.Name is null ? (Input.Name = "") : Input.Name.Trim();
            if (Input.Name == "")
            {
                isValid = false;
                errs[nameof(Input.Name)] = "Name is required!";
            }
            //CourseImageLink
            Input.CourseImageLink = Input.CourseImageLink is null ?
                (Input.CourseImageLink = "") : Input.CourseImageLink.Trim();
            if (Input.CourseImageLink == "")
            {
                isValid = false;
                errs[nameof(Input.CourseImageLink)] = "Course's Image link is required!";
            }
            //About
            Input.About = Input.About is null ? (Input.About = "") : Input.About.Trim();
            if (Input.About == "" || Input.About.Length > 5000)
            {
                isValid = false;
                errs[nameof(Input.About)] = "About section is required and not to exceed 5000 characters!";
            }

            return isValid;
        }
    }
}
