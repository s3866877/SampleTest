using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SampleTest.Models
{
    public class OfficeAssignment
    {
        [Key, ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public virtual Instructor Instructor {get;set;}
        [Required, StringLength(50)]
        public string Location { get; set; }
    }
}
