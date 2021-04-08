namespace VanessasBeautyShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeBeautyShopIDnullOnCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customer", "BeautyShopId", "dbo.BeautyShop");
            DropIndex("dbo.Customer", new[] { "BeautyShopId" });
            AlterColumn("dbo.Customer", "BeautyShopId", c => c.Int());
            CreateIndex("dbo.Customer", "BeautyShopId");
            AddForeignKey("dbo.Customer", "BeautyShopId", "dbo.BeautyShop", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "BeautyShopId", "dbo.BeautyShop");
            DropIndex("dbo.Customer", new[] { "BeautyShopId" });
            AlterColumn("dbo.Customer", "BeautyShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customer", "BeautyShopId");
            AddForeignKey("dbo.Customer", "BeautyShopId", "dbo.BeautyShop", "Id", cascadeDelete: true);
        }
    }
}
