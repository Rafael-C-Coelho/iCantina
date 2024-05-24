namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dishes", "Active");
        }
    }
}
