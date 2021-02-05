using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SampleTest.Models
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string FirstMidName { get; set; }
        public string FullName { 
            get
            {
                return FirstMidName + LastName;
            } 
        }
        [DataType(DataType.Date), Column(TypeName = "Date")]
        public DateTime EnrollmentDate { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
