namespace DeyanStyleClothing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDatabase : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('','','','','')");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Jeans','M','30','£45','Description to come.')");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Dress','W','23','£34','Description to come.')");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Gloves','M','35','£12','Description to come.')");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Jeans Denim','M','30','£45','Description to come.')");
            Sql("INSERT INTO dbo.ItemModels(Name, Type, Size, Price, Description) VALUES('Hat','M','4','£5','Description to come.')");
        }

        public override void Down()
        {
        }
    }
}
