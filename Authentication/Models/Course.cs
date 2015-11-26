using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Authentication.Models
{

    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public DateTime Duedate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
