using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SampleTest.Models
{
    public class Instructor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string FirstMidName { get; set; }
        public string FullName
        {
            get
            {
                return FirstMidName + LastName;
            }
        }
        [DataType(DataType.Date), Column(TypeName = "Date")]
        public DateTime HireDate { get; set; }
        public virtual List<CourseAssignment> CourseAssignments { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual List<Department> Departments { get; set; }

    }
}
