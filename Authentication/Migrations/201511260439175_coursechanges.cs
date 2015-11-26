namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coursechanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Duedate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "Completed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Enrollments", "StudentID");
            DropColumn("dbo.Enrollments", "Grade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "Grade", c => c.Int());
            AddColumn("dbo.Enrollments", "StudentID", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "Completed");
            DropColumn("dbo.Courses", "Duedate");
        }
    }
}
