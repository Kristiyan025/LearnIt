using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LearnIt.Models
{
    public class UserDataModel : IdentityUser
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "FullName is required!")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; } //true - male, false - female

        [Required(ErrorMessage = "isStudent is required!")]
        public bool isStudent { get; set; }

        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Country { get; set; }

        [StringLength(300, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string ImageLink { get; set; }

        [StringLength(2000, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Bio { get; set; }

        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string GitHub { get; set; }

        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Facebook { get; set; }

        [StringLength(200, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string StackOverflow { get; set; }

        public List<UsersCoursesDataModel> Courses { get; set; }

        public List<CourseDataModel> GetCourses()
        {
            return this.Courses
                .Select(x => x.Course)
                .ToList();
        }
    }
}
