using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnIt.Models
{
    public class UsersCoursesDataModel
    {
        public string UserId { get; set; }

        public UserDataModel User { get; set; }

        public string CourseId { get; set; }

        public CourseDataModel Course { get; set; }
    }
}
