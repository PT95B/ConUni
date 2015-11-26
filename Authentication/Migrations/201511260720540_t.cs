namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Completed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Completed", c => c.Boolean(nullable: false));
        }
    }
}
