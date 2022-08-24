using CodeFirstAssignment.Enums;
using System.Collections.Generic;

namespace CodeFirstAssignment.DataModel
{
    using CodeFirstAssignment.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        [Key]
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CourseUnit { get; set; }
        public Level CourseLevel { get; set; }
    }
}