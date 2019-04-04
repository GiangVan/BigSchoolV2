namespace BigSchool2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'DEVELOPMEMT')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'HAHAHA')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'YOLO')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4, 'HOHOHO')");
        }
        
        public override void Down()
        {
        }
    }
}
