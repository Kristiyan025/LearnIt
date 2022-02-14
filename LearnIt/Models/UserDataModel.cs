using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LearnIt.Models
{
    public class UserDataModel : IdentityUser
    {
        public string CustomTag { get; set; }

        [Key]
        [PersonalData]
        public string Id { get; set; }

        [PersonalData]
        [Required(ErrorMessage = "FullName is required!")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string FullName { get; set; }

        [PersonalData]
        public DateTime BirthDate { get; set; }

        [PersonalData]
        public bool Gender { get; set; } //true - male, false - female

        [PersonalData]
        [Required(ErrorMessage = "isStudent is required!")]
        public bool isStudent { get; set; }

        [PersonalData]
        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Country { get; set; }

        [PersonalData]
        [StringLength(300, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string ImageLink { get; set; }

        [PersonalData]
        [StringLength(2000, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Bio { get; set; }

        [PersonalData]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string GitHub { get; set; }

        [PersonalData]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Facebook { get; set; }

        [PersonalData]
        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string StackOverflow { get; set; }

        [PersonalData]
        public List<UsersCoursesDataModel> Courses { get; set; }

        public List<CourseDataModel> GetCourses()
        {
            return this.Courses
                .Select(x => x.Course)
                .ToList();
        }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
    }
}
