namespace LearnIt.Areas.Identity.Pages.Account
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using LearnIt.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using LearnIt.Data;
    using Microsoft.EntityFrameworkCore;

    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<UserDataModel> _signInManager;
        private readonly ILogger<LogoutModel> _logger;
        private ApplicationDbContext _context;

        public LogoutModel(
            SignInManager<UserDataModel> signInManager, 
            ILogger<LogoutModel> logger,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        public void OnGet()
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
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
