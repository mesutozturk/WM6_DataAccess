namespace Reverse.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AddedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "AddedDate");
        }
    }
}
