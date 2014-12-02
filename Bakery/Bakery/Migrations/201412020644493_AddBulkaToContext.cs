namespace Bakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBulkaToContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bulkas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Taste = c.String(),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BulkaBakeries",
                c => new
                    {
                        Bulka_Id = c.Int(nullable: false),
                        Bakery_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bulka_Id, t.Bakery_Id })
                .ForeignKey("dbo.Bulkas", t => t.Bulka_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bakeries", t => t.Bakery_Id, cascadeDelete: true)
                .Index(t => t.Bulka_Id)
                .Index(t => t.Bakery_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BulkaBakeries", "Bakery_Id", "dbo.Bakeries");
            DropForeignKey("dbo.BulkaBakeries", "Bulka_Id", "dbo.Bulkas");
            DropIndex("dbo.BulkaBakeries", new[] { "Bakery_Id" });
            DropIndex("dbo.BulkaBakeries", new[] { "Bulka_Id" });
            DropTable("dbo.BulkaBakeries");
            DropTable("dbo.Bulkas");
        }
    }
}
