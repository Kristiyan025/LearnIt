namespace LearnIt.Controllers
{
    using LearnIt.Data;
    using LearnIt.Validation;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class EditInfoController : Controller
    {
        private readonly ILogger<EditInfoController> _logger;
        private ApplicationDbContext _context;

        public EditInfoController(ILogger<EditInfoController> logger, ApplicationDbContext context)
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
            [Display(Name = "Full Name")]
            public string FullName { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Birth Date")]
            public DateTime BirthDate { get; set; }

            [Display(Name = "Gender")]
            public bool Gender { get; set; } //true - male, false - female

            [Display(Name = "Country")]
            public string Country { get; set; }

            [Display(Name = "ImageLink")]
            public string ImageLink { get; set; }

            [DataType(DataType.MultilineText)]
            [Display(Name = "Bio")]
            public string Bio { get; set; }

            [Display(Name = "GitHub Account")]
            public string GitHub { get; set; }

            [Display(Name = "Facebook Account")]
            public string Facebook { get; set; }

            [Display(Name = "StackOverflow Account")]
            public string StackOverflow { get; set; }
        }

        public IActionResult EditInfo()
        {
            BuildViewBag();

            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            return View();
        }
        
        [HttpPost]
        public IActionResult UpdateInfo()
        {
            BuildViewBag();

            if (ViewBag.User is null) return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                Dictionary<string, string> errs;
                if (isValidInput(out errs))
                {
                    var user = _context.Users.First(x => x.UserName == this.User.Identity.Name);
                    //FullName
                    if (!(Input.FullName == "" || !InputValidator.IsOnlyFromLettersAndSpaces(Input.FullName)))
                    {
                        user.FullName = Input.FullName;
                    }
                    //Gender
                    user.Gender = Input.Gender;
                    //BirthDate
                    if (!(Input.BirthDate > DateTime.Now || Input.BirthDate.Year < 1920))
                    {
                        user.BirthDate = Input.BirthDate;
                    }
                    //Country
                    if (!(Input.Country == "" || !InputValidator.IsOnlyFromLettersAndSpaces(Input.Country)))
                    {
                        user.Country = Input.Country;
                    }
                    //ImageLink
                    if (Input.ImageLink != "")
                    {
                        user.ImageLink = Input.ImageLink;
                    }
                    //Bio
                    if (Input.Bio.Length > 15 || Input.Bio.Length <= 2000)
                    {
                        user.Bio = Input.Bio;
                    }
                    //GitHub
                    if (Input.GitHub != "")
                    {
                        user.GitHub = Input.GitHub;
                    }
                    //Facebook
                    if (Input.Facebook != "")
                    {
                        user.Facebook = Input.Facebook;
                    }
                    //StackOverflow
                    if (Input.StackOverflow != "")
                    {
                        user.StackOverflow = Input.StackOverflow;
                    }

                    _context.SaveChanges();
                    return RedirectToAction("MyInfo", "Home");
                }
                else
                {
                    foreach (var err in errs)
                    {
                        ModelState.AddModelError(err.Key, err.Value);
                    }

                    return View("EditInfo");
                }
            }

            // If we got this far, something failed, redisplay form
            return View("EditInfo");
        }

        private bool isValidInput(out Dictionary<string, string> errs)
        {
            bool isValid = true;
            errs = new Dictionary<string, string>();
            //FullName
            Input.FullName = Input.FullName is null ? (Input.FullName = "") : Input.FullName.Trim();
            if(Input.FullName == "" || !InputValidator.IsOnlyFromLettersAndSpaces(Input.FullName))
            {
                isValid = false;
                errs[nameof(Input.FullName)] = "Full Name must contain only letters and it is required!";
            }
            //BirthDate
            if (Input.BirthDate > DateTime.Now)
            {
                isValid = false;
                errs[nameof(Input.BirthDate)] = "Birth Date must be before now!";
            }
            //Country
            Input.Country = Input.Country is null ? (Input.Country = "") : Input.Country.Trim();
            if (!InputValidator.IsOnlyFromLettersAndSpaces(Input.Country))
            {
                isValid = false;
                errs[nameof(Input.Country)] = "Country must contain only letters and it is required!";
            }
            ////ImageLink
            //Input.ImageLink = Input.ImageLink is null ? (Input.ImageLink = "") : Input.ImageLink.Trim();
            //if (InputValidator.ContainsSpaces(Input.ImageLink))
            //{
            //    isValid = false;
            //    errs[nameof(Input.ImageLink)] = "Image link is not to contain white spaces!";
            //}
            //Bio
            Input.Bio = Input.Bio is null ? (Input.Bio = "") : Input.Bio.Trim();
            if (Input.Bio.Length > 2000)
            {
                isValid = false;
                errs[nameof(Input.Bio)] = "Bio must be shorter than 2000 symbols!";
            }
            ////GitHub
            //Input.GitHub = Input.GitHub is null ? (Input.GitHub = "") : Input.GitHub.Trim();
            //if (InputValidator.ContainsSpaces(Input.GitHub))
            //{
            //    isValid = false;
            //    errs[nameof(Input.GitHub)] = "GitHub link is not to contain white spaces!";
            //}
            ////Facebook
            //Input.Facebook = Input.Facebook is null ? (Input.Facebook = "") : Input.Facebook.Trim();
            //if (InputValidator.ContainsSpaces(Input.Facebook))
            //{
            //    isValid = false;
            //    errs[nameof(Input.Facebook)] = "Facebook link is not to contain white spaces!";
            //}
            ////StackOverflow
            //Input.StackOverflow = Input.StackOverflow is null ? (Input.StackOverflow = "") : Input.StackOverflow.Trim();
            //if (InputValidator.ContainsSpaces(Input.StackOverflow))
            //{
            //    isValid = false;
            //    errs[nameof(Input.StackOverflow)] = "StackOverflow link is not to contain white spaces!";
            //}

            return isValid;
        }
    }
}
