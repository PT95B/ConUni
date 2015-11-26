namespace Authentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _try : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "Enrolled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollments", "Enrolled");
        }
    }
}
