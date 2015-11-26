namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class students : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            AddColumn("dbo.Enrollments", "Student_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Enrollments", "Student_Id");
            AddForeignKey("dbo.Enrollments", "Student_Id", "dbo.AspNetUsers", "Id");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.Enrollments", "Student_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Enrollments", new[] { "Student_Id" });
            DropColumn("dbo.Enrollments", "Student_Id");
            CreateIndex("dbo.Enrollments", "StudentID");
            AddForeignKey("dbo.Enrollments", "StudentID", "dbo.Students", "ID", cascadeDelete: true);
        }
    }
}
