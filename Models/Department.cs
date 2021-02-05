using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SampleTest.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Column(TypeName = "money"), DataType(DataType.Currency)]
        public decimal Budget { get; set; }
        [DataType(DataType.Date), Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [ForeignKey("Administrator")]
        public int InstructorID { get; set; }
        public virtual Instructor Administrator { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
