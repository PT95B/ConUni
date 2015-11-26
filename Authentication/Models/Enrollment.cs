using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication.Models
{

        //public enum Grade
        //{
        //    A, B, C, D, F
        //}

        public class Enrollment
        {
            public int EnrollmentID { get; set; }
            public int CourseID { get; set; }
            public bool Enrolled { get; set; }
            //public string EnrolledStudent { get; set; }
            public string StudentID { get; set; }
            //public Grade? Grade { get; set; }



            public virtual Course Course { get; set; }
            [ForeignKey("StudentID")]
            public virtual ApplicationUser Student { get; set; }
        }
}
