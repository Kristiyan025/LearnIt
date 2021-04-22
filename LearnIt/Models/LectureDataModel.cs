using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearnIt.Models
{
    public class LectureDataModel
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(80, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "StartDate is required!")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "About is required!")]
        [StringLength(150, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string About { get; set; }

        [StringLength(300, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string PresentationLink { get; set; }

        [StringLength(300, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string ExercisesLink { get; set; }

        [Required(ErrorMessage = "VideoLink is required!")]
        [StringLength(300, ErrorMessage = "The {0} value cannot exceed {1} characters!")]
        public string VideoLink { get; set; }

        [Required(ErrorMessage = "Course to the lecture is required!")]
        public virtual CourseDataModel Course { get; set; }
    }
}
