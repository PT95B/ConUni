namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foregn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Enrollments", name: "Student_Id", newName: "StudentID");
            RenameIndex(table: "dbo.Enrollments", name: "IX_Student_Id", newName: "IX_StudentID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Enrollments", name: "IX_StudentID", newName: "IX_Student_Id");
            RenameColumn(table: "dbo.Enrollments", name: "StudentID", newName: "Student_Id");
        }
    }
}
