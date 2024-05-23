namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Dish_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Name = c.String(),
                        NIF = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Reservation_Id = c.Int(),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.InvoiceLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        Description = c.String(),
                        Invoice_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.Invoice_Id)
                .Index(t => t.Invoice_Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Total = c.Single(nullable: false),
                        Professor_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Professor_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Penalties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Balance = c.Single(nullable: false),
                        Name = c.String(),
                        NIF = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Dish_Id = c.Int(),
                        Menu_Id = c.Int(),
                        Penalty_Id = c.Int(),
                        Professor_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Penalties", t => t.Penalty_Id)
                .ForeignKey("dbo.Professors", t => t.Professor_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Dish_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Penalty_Id)
                .Index(t => t.Professor_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        QuantityAvailable = c.Int(nullable: false),
                        PriceStudent = c.Double(nullable: false),
                        PriceProfessor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentNumber = c.Int(nullable: false),
                        Balance = c.Single(nullable: false),
                        Name = c.String(),
                        NIF = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Invoices", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Reservations", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Reservations", "Penalty_Id", "dbo.Penalties");
            DropForeignKey("dbo.Reservations", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Extras", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Dishes", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Extras", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.Invoices", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.InvoiceLines", "Invoice_Id", "dbo.Invoices");
            DropForeignKey("dbo.Dishes", "Dish_Id", "dbo.Dishes");
            DropIndex("dbo.Reservations", new[] { "Student_Id" });
            DropIndex("dbo.Reservations", new[] { "Professor_Id" });
            DropIndex("dbo.Reservations", new[] { "Penalty_Id" });
            DropIndex("dbo.Reservations", new[] { "Menu_Id" });
            DropIndex("dbo.Reservations", new[] { "Dish_Id" });
            DropIndex("dbo.Invoices", new[] { "Student_Id" });
            DropIndex("dbo.Invoices", new[] { "Professor_Id" });
            DropIndex("dbo.InvoiceLines", new[] { "Invoice_Id" });
            DropIndex("dbo.Extras", new[] { "Menu_Id" });
            DropIndex("dbo.Extras", new[] { "Reservation_Id" });
            DropIndex("dbo.Dishes", new[] { "Menu_Id" });
            DropIndex("dbo.Dishes", new[] { "Dish_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Menus");
            DropTable("dbo.Reservations");
            DropTable("dbo.Professors");
            DropTable("dbo.Penalties");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceLines");
            DropTable("dbo.Extras");
            DropTable("dbo.Employees");
            DropTable("dbo.Dishes");
        }
    }
}
