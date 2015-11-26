namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    internal sealed class Configuration : DbMigrationsConfiguration<Authentication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Authentication.Models.ApplicationDbContext";
        }

        protected override void Seed(Authentication.Models.ApplicationDbContext context)
        {
            var courses = new List<Models.Course>
            {
                new Models.Course {CourseID = 1050, Title = "Chemistry",      Assignments = 3,  Duedate = new DateTime(2011,03,04), description = "Chemicals and matter",},
                new Models.Course {CourseID = 4022, Title = "Microeconomics", Assignments = 3,  Duedate = new DateTime(2017,03,04), description = "Small Economics ", },
                new Models.Course {CourseID = 4041, Title = "Macroeconomics", Assignments = 3, Duedate = new DateTime(2016,02,04), description = "Economics on the large scale",},
                new Models.Course {CourseID = 1045, Title = "Calculus",       Assignments = 4, Duedate = new DateTime(2015,03,04), description = "Calculating Change",},
                new Models.Course {CourseID = 3141, Title = "Trigonometry",   Assignments = 4, Duedate = new DateTime(2014,03,04), description = "Tringangles and more",},
                new Models.Course {CourseID = 2021, Title = "Composition",    Assignments = 3, Duedate = new DateTime(2013,06,03), description = "Making things",},
                new Models.Course {CourseID = 2042, Title = "Literature",     Assignments = 4, Duedate = new DateTime(2012,03,04), description = "Lots of books",}
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();
        }
    }
}
