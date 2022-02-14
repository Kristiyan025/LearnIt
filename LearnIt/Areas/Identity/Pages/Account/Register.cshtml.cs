namespace LearnIt.Areas.Identity.Pages.Account
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authorization;
    using LearnIt.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using LearnIt.Data;
    using Microsoft.EntityFrameworkCore;

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<UserDataModel> _signInManager;
        private readonly UserManager<UserDataModel> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private ApplicationDbContext _context;

        public RegisterModel(
            UserManager<UserDataModel> userManager,
            SignInManager<UserDataModel> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "UserName is required!")]
            [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
            [Display(Name = "Username")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "FullName is required!")]
            [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
            [Display(Name = "Full Name")]
            public string FullName { get; set; }

            [Required(ErrorMessage = "Email is required!")]
            [StringLength(70, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(70, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "isStudent is required!")]
            [Display(Name = "Student / Teacher")]
            public bool isStudent { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            var courses = _context.Courses.ToList();
            ViewData["Courses"] = courses;
            var teachers = _context.Users
                .Where(x => !x.isStudent)
                .Select(x => x.UserName)
                .ToList();
            ViewData["User"] = _context.Users
                .Where(x => x.UserName == this.User.Identity.Name)
                .Include(x => x.Courses)
                .SingleOrDefault();

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            bool isTeacher = !(this.User.Identity.Name is null) &&
                !_context.Users.Where(x => x.UserName == this.User.Identity.Name).First().isStudent;
            var courses = _context.Courses.ToList();
            ViewData["Courses"] = courses;
            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean register process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new UserDataModel
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = Input.UserName,
                    FullName = Input.FullName,
                    Email = Input.Email,
                    ///Change isStudent to false to create one teacher at the start, 
                    ///then change it back to !isTeacher
                    isStudent = !isTeacher //false//
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
