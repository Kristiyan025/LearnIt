namespace LearnIt.Controllers
{
    using LearnIt.Data;
    using LearnIt.Models;
    using LearnIt.Validation;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class LectureController : Controller
    {
        private readonly ILogger<LectureController> _logger;
        private ApplicationDbContext _context;

        public LectureController(ILogger<LectureController> logger, ApplicationDbContext context)
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
        
        private LectureDataModel Lecture { get; set; }

        public class FormModel
        {
            [Display(Name = "Name:")]
            public string Name { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Start Date:")]
            public DateTime StartDate { get; set; }

            [Display(Name = "About:")]
            public string About { get; set; }

            [Display(Name = "Presentation Link:")]
            public string PresentationLink { get; set; }

            [Display(Name = "Exercises Link:")]
            public string ExercisesLink { get; set; }

            [Display(Name = "Video Link:")]
            public string VideoLink { get; set; }

            public string LectureId { get; set; }

            public string CourseId { get; set; }
        }

        public IActionResult EditLecture(string id)
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            Lecture = _context.Lectures
                .Where(x => x.Id == id)
                .Include(x => x.Course)
                .Include(x => x.Course.Lectures)
                .FirstOrDefault();
            ViewBag.Lecture = Lecture;
            ViewBag.LecturesCourse = Lecture.Course;
            return View("EditLecture", Input);
        }

        [HttpPost]
        public IActionResult UpdateLecture()
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            Lecture = _context.Lectures
                .Where(x => x.Id == Input.LectureId)
                .Include(x => x.Course)
                .Include(x => x.Course.Lectures)
                .FirstOrDefault();
            ViewBag.Lecture = Lecture;
            ViewBag.LecturesCourse = Lecture.Course;

            if (ModelState.IsValid)
            {
                Dictionary<string, string> errs;
                if (isValidInput(out errs))
                {
                    //Name
                    if (Input.Name != "")
                    {
                        Lecture.Name = Input.Name;
                    }
                    //StartDate
                    if (DateTime.Now.Year - Input.StartDate.Year <= 11)
                    {
                        Lecture.StartDate = Input.StartDate;
                    }
                    //About
                    if (Input.About != "" && Input.About.Length <= 150)
                    {
                        Lecture.About = Input.About;
                    }
                    //PresentationLink
                    if (Input.PresentationLink != "")
                    {
                        Lecture.PresentationLink = Input.PresentationLink;
                    }
                    //ExercisesLink
                    if (Input.ExercisesLink != "")
                    {
                        Lecture.ExercisesLink = Input.ExercisesLink;
                    }
                    //VideoLink
                    if (Input.VideoLink != "")
                    {
                        Lecture.VideoLink = Input.VideoLink;
                    }


                    DateValidator.UpateCourseEndPoints(Lecture.Course);
                    _context.SaveChanges();
                    return RedirectToAction("Course", "Home", new { ViewBag.LecturesCourse.Id });
                }
                else
                {
                    foreach (var err in errs)
                    {
                        ModelState.AddModelError(err.Key, err.Value);
                    }

                    return View("EditLecture");
                }
            }

            // If we got this far, something failed, redisplay form
            return View("EditLecture");
        }

        public IActionResult AddLecture(string id)
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            ViewBag.CourseId = id;

            return View("AddLecture", Input);
        }

        [HttpPost]
        public IActionResult AddLectureOnPost()
        {
            BuildViewBag();
            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            ViewBag.CourseId = Input.CourseId;

            if (ModelState.IsValid)
            {
                Dictionary<string, string> errs;
                if (isValidInput(out errs))
                {
                    var course = _context.Courses
                        .Where(x => x.Id == Input.CourseId)
                        .Include(x => x.Lectures)
                        .FirstOrDefault();
                    LectureDataModel lecture = new LectureDataModel();
                    lecture.Id = Guid.NewGuid().ToString();
                    //Name
                    if (Input.Name != "")
                    {
                        lecture.Name = Input.Name;
                    }
                    //StartDate
                    if (DateTime.Now.Year - Input.StartDate.Year <= 11)
                    {
                        lecture.StartDate = Input.StartDate;
                    }
                    //About
                    if (Input.About != "" && Input.About.Length <= 150)
                    {
                        lecture.About = Input.About;
                    }
                    //PresentationLink
                    if (Input.PresentationLink != "")
                    {
                        lecture.PresentationLink = Input.PresentationLink;
                    }
                    //ExercisesLink
                    if (Input.ExercisesLink != "")
                    {
                        lecture.ExercisesLink = Input.ExercisesLink;
                    }
                    //VideoLink
                    if (Input.VideoLink != "")
                    {
                        lecture.VideoLink = Input.VideoLink;
                    }

                    _context.Lectures.Add(lecture);
                    course.Lectures.Add(lecture);
                    lecture.Course = course;
                    DateValidator.UpateCourseEndPoints(course);
                    _context.SaveChanges();
                    return RedirectToAction("Course", "Home", new { id = Input.CourseId });
                }
                else
                {
                    foreach (var err in errs)
                    {
                        ModelState.AddModelError(err.Key, err.Value);
                    }

                    return View("AddLecture");
                }
            }

            // If we got this far, something failed, redisplay form
            return View("AddLecture");
        }

        public IActionResult DeleteLecture(string id)
        {
            var lecture = _context.Lectures
                .Where(x => x.Id == id)
                .Include(x => x.Course)
                .Include(x => x.Course.Lectures)
                .FirstOrDefault();
            if(lecture is null) return RedirectToAction("Index", "Home");

            string courseId = lecture.Course.Id;
            lecture.Course.Lectures.Remove(lecture);
            DateValidator.UpateCourseEndPoints(lecture.Course);
            _context.Lectures.Remove(lecture);
            _context.SaveChanges();

            return RedirectToAction("Course", "Home", new { id = courseId });
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
            //StartDate
            if (DateTime.Now.Year - Input.StartDate.Year > 11)
            {
                isValid = false;
                errs[nameof(Input.StartDate)] = $"Start Date's year must be at least {DateTime.Now.Year - 11}!";
            }
            //About
            Input.About = Input.About is null ? (Input.About = "") : Input.About.Trim();
            if (Input.About == "" || Input.About.Length > 150)
            {
                isValid = false;
                errs[nameof(Input.About)] = "About section is required and not to exceed 150 characters!";
            }
            //PresentationLink
            Input.PresentationLink = Input.PresentationLink is null ? 
                (Input.PresentationLink = "") : Input.PresentationLink.Trim();
            if (Input.PresentationLink == "")
            {
                isValid = false;
                errs[nameof(Input.PresentationLink)] = "Presentation link is required!";
            }
            //ExercisesLink
            Input.ExercisesLink = Input.ExercisesLink is null ?
                (Input.ExercisesLink = "") : Input.ExercisesLink.Trim();
            if (Input.ExercisesLink == "")
            {
                isValid = false;
                errs[nameof(Input.ExercisesLink)] = "Exercises link is required!";
            }
            //VideoLink
            Input.VideoLink = Input.VideoLink is null ?
                (Input.VideoLink = "") : Input.VideoLink.Trim();
            if (Input.VideoLink == "")
            {
                isValid = false;
                errs[nameof(Input.VideoLink)] = "Video link is required!";
            }

            return isValid;
        }
    }
}
