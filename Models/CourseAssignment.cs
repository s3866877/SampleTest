using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleTest.Models
{
    [Keyless]
    public class CourseAssignment
    {
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
