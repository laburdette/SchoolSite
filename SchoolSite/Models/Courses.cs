using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSite.Models
{
    public class Courses
    {
        
            [Key]
        public int ID { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        public double Credits { get; set; }

        [ForeignKey("Enrollment")]
        public int EnrollmentID { get; set; }
        public virtual ICollection <Enrollment> Enrollment { get; set; }

        
    }
}