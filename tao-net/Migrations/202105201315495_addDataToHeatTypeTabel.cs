namespace tao_net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataToHeatTypeTabel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO HeatTypes(Name, Price) VALUES('elektricitet', '200')");
            Sql("INSERT INTO HeatTypes(Name, Price) VALUES('Natur gas', '100')");
            Sql("INSERT INTO HeatTypes(Name, Price) VALUES('Olie', '500')");
            Sql("INSERT INTO HeatTypes(Name, Price) VALUES('District heating', '200')");
            Sql("INSERT INTO HeatTypes(Name, Price) VALUES('Heat pump', '340')");
            Sql("INSERT INTO HeatTypes(Name, Price) VALUES('Biofuels', '100')");
        }
        
        public override void Down()
        {
        }
    }
}
