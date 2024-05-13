namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "NIF", c => c.String());
            AlterColumn("dbo.Professors", "NIF", c => c.String());
            AlterColumn("dbo.Students", "NIF", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "NIF", c => c.Int(nullable: false));
            AlterColumn("dbo.Professors", "NIF", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "NIF", c => c.Int(nullable: false));
        }
    }
}
