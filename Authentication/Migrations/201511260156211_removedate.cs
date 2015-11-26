namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "EnrollmentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "EnrollmentDate", c => c.DateTime(nullable: false));
        }
    }
}
