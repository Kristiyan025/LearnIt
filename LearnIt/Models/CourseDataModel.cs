using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnIt.Models
{
    public class CourseDataModel
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "StartDate is required!")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required!")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "CourseImageLink is required!")]
        [StringLength(300, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string CourseImageLink { get; set; }

        [StringLength(5000, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string About { get; set; }

        /*[Required(ErrorMessage = "List of lectures to the course is required!")]//*/
        public virtual List<LectureDataModel> Lectures { get; set; }

        public virtual List<UsersCoursesDataModel> Users { get; set; }
    }
}
