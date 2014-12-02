namespace Bakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressBakeryToCook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cooks", "Address", c => c.String());
            AddColumn("dbo.Cooks", "BakeryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cooks", "BakeryId");
            DropColumn("dbo.Cooks", "Address");
        }
    }
}
