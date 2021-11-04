namespace CustomerManager_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodMenus", "Food_Id", "dbo.Foods");
            DropIndex("dbo.FoodMenus", new[] { "Food_Id" });
            DropPrimaryKey("dbo.Foods");
            DropPrimaryKey("dbo.FoodMenus");
            AlterColumn("dbo.Foods", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.FoodMenus", "Food_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Foods", "Id");
            AddPrimaryKey("dbo.FoodMenus", new[] { "Food_Id", "Menu_Id" });
            CreateIndex("dbo.FoodMenus", "Food_Id");
            AddForeignKey("dbo.FoodMenus", "Food_Id", "dbo.Foods", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodMenus", "Food_Id", "dbo.Foods");
            DropIndex("dbo.FoodMenus", new[] { "Food_Id" });
            DropPrimaryKey("dbo.FoodMenus");
            DropPrimaryKey("dbo.Foods");
            AlterColumn("dbo.FoodMenus", "Food_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Foods", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.FoodMenus", new[] { "Food_Id", "Menu_Id" });
            AddPrimaryKey("dbo.Foods", "Id");
            CreateIndex("dbo.FoodMenus", "Food_Id");
            AddForeignKey("dbo.FoodMenus", "Food_Id", "dbo.Foods", "Id", cascadeDelete: true);
        }
    }
}
