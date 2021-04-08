namespace VanessasBeautyShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBeautyShopTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BeautyShop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShopName = c.String(nullable: false),
                        ShopPhoneNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customer", "BeautyShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customer", "BeautyShopId");
            AddForeignKey("dbo.Customer", "BeautyShopId", "dbo.BeautyShop", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "BeautyShopId", "dbo.BeautyShop");
            DropIndex("dbo.Customer", new[] { "BeautyShopId" });
            DropColumn("dbo.Customer", "BeautyShopId");
            DropTable("dbo.BeautyShop");
        }
    }
}
