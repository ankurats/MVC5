namespace MVCDemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "EmailAddress", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "EmailAddress", c => c.String());
        }
    }
}
