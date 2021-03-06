namespace tao_net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHeatType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeatTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HeatTypes");
        }
    }
}
