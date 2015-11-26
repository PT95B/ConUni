namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Assignments", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "description", c => c.String());
            AddColumn("dbo.Enrollments", "EnrolledStudent", c => c.String());
            AddColumn("dbo.AspNetUsers", "Identity", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "Credits");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Credits", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "Identity");
            DropColumn("dbo.Enrollments", "EnrolledStudent");
            DropColumn("dbo.Courses", "description");
            DropColumn("dbo.Courses", "Assignments");
        }
    }
}
