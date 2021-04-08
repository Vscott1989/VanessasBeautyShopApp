namespace VanessasBeautyShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedApointmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeOfArrival = c.String(),
                        BeautitionName = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointment", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Appointment", new[] { "CustomerId" });
            DropTable("dbo.Appointment");
        }
    }
}
