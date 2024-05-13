namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDishes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        Dish_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .Index(t => t.Dish_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "Dish_Id", "dbo.Dishes");
            DropIndex("dbo.Dishes", new[] { "Dish_Id" });
            DropTable("dbo.Dishes");
        }
    }
}
