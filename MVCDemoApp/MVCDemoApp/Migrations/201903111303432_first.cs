namespace MVCDemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "EmailAddress");
        }
    }
}
