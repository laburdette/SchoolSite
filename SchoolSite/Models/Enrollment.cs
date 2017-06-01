using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSite.Models
{
    public class Enrollment
    {
        [Key]
        public int ID { get; set; }
        public double GPA { get; set; }

        [Display(Name = "Enrolled?")]
        public bool isEnrolled { get; set; }

        [ForeignKey("Courses")]
        public int CoursesID { get; set; }
        public virtual Courses Courses { get; set; }

        [ForeignKey("Students")]
        public int StudentsID { get; set; }
        public virtual Students Students { get; set; }
    }
}