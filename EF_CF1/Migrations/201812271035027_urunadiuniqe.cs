namespace EF_CF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class urunadiuniqe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "Eklenme", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            CreateIndex("dbo.Urunler", "ProductName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Urunler", new[] { "ProductName" });
            DropColumn("dbo.Urunler", "Eklenme");
        }
    }
}
