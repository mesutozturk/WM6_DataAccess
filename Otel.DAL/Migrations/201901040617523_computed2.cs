namespace Otel.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class computed2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReservationBills", "SubTotal", c => c.Decimal(nullable: false, precision: 11, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReservationBills", "SubTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
