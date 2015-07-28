namespace Car_Dealership_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Vehicles");
            AddColumn("dbo.Vehicles", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Vehicles", "VIN", c => c.String());
            AddPrimaryKey("dbo.Vehicles", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Vehicles");
            AlterColumn("dbo.Vehicles", "VIN", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Vehicles", "ID");
            AddPrimaryKey("dbo.Vehicles", "VIN");
        }
    }
}
