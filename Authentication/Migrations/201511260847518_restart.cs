namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restart : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Enrollments", "EnrolledStudent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "EnrolledStudent", c => c.String());
        }
    }
}
