using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleTest.Models
{
    public enum EnrollmentGrade
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6
    }
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnrollmentID { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public EnrollmentGrade Grade { get; set; }

    }
}
