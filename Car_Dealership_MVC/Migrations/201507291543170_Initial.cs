namespace Car_Dealership_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VIN = c.String(),
                        make = c.String(),
                        model = c.String(),
                        color = c.String(),
                        year = c.Int(nullable: false),
                        MSRP = c.Double(nullable: false),
                        MPG = c.Double(nullable: false),
                        imagePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Password = c.String(),
                        carID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Vehicles");
        }
    }
}
