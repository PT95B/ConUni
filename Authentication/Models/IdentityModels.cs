using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using MySql.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace Authentication.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public int Identity{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("SchoolContext", throwIfV1Schema: false)
        {
        }
        //static ApplicationDbContext()
        //{
        //    DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        //}

        //public DbSet<ApplicationUser> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<IdentityRole>()
            //    .Property(c => c.Name)
            //    .HasMaxLength(128)
            //    .IsRequired();
            //modelBuilder
            //   .Entity<ApplicationUser>()
            //   .Property(p => p.UserName)
            //   .HasMaxLength(255);

        }
    }
}