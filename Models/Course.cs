using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SampleTest.Models
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Required, Range(0, 5)]
        public int Credits { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }
        public virtual List<CourseAssignment> CourseAssignments { get; set; }
    }
}
