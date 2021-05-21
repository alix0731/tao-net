namespace tao_net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerForreignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "HeatTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "HeatTypeId");
            AddForeignKey("dbo.Customers", "HeatTypeId", "dbo.HeatTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "HeatTypeId", "dbo.HeatTypes");
            DropIndex("dbo.Customers", new[] { "HeatTypeId" });
            DropColumn("dbo.Customers", "HeatTypeId");
        }
    }
}
