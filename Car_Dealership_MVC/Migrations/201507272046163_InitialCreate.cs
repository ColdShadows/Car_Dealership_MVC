namespace Car_Dealership_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VIN = c.String(nullable: false, maxLength: 128),
                        make = c.String(nullable: false, maxLength: 60),
                        model = c.String(nullable: false),
                        color = c.String(nullable: false),
                        year = c.Int(nullable: false),
                        MSRP = c.Double(nullable: false),
                        MPG = c.Double(nullable: false)

                    })
                .PrimaryKey(t => t.VIN);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
