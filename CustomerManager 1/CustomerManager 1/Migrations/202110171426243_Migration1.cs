namespace CustomerManager_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        Age = c.Int(),
                        CurrentWeight = c.Double(nullable: false),
                        TargetWeight = c.Double(nullable: false),
                        BodyFatPercent = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        ListingDate = c.DateTime(nullable: false),
                        Mail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Calcium = c.String(),
                        Calories = c.String(),
                        Carbs = c.String(),
                        Protein = c.String(),
                        Fat = c.String(),
                        Iron = c.String(),
                        B12 = c.String(),
                        VitaminD = c.String(),
                        Fiber = c.String(),
                        Image = c.String(),
                        NotesAndAmounts = c.String(),
                        FoodCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrainingPrograms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuCustomers",
                c => new
                    {
                        Menu_Id = c.String(nullable: false, maxLength: 128),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_Id, t.Customer_Id })
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Menu_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.FoodMenus",
                c => new
                    {
                        Food_Id = c.String(nullable: false, maxLength: 128),
                        Menu_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Food_Id, t.Menu_Id })
                .ForeignKey("dbo.Foods", t => t.Food_Id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Food_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.TrainingProgramCustomers",
                c => new
                    {
                        TrainingProgram_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TrainingProgram_Id, t.Customer_Id })
                .ForeignKey("dbo.TrainingPrograms", t => t.TrainingProgram_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.TrainingProgram_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.ExerciseTrainingPrograms",
                c => new
                    {
                        Exercise_Id = c.Int(nullable: false),
                        TrainingProgram_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exercise_Id, t.TrainingProgram_Id })
                .ForeignKey("dbo.Exercises", t => t.Exercise_Id, cascadeDelete: true)
                .ForeignKey("dbo.TrainingPrograms", t => t.TrainingProgram_Id, cascadeDelete: true)
                .Index(t => t.Exercise_Id)
                .Index(t => t.TrainingProgram_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseTrainingPrograms", "TrainingProgram_Id", "dbo.TrainingPrograms");
            DropForeignKey("dbo.ExerciseTrainingPrograms", "Exercise_Id", "dbo.Exercises");
            DropForeignKey("dbo.TrainingProgramCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.TrainingProgramCustomers", "TrainingProgram_Id", "dbo.TrainingPrograms");
            DropForeignKey("dbo.FoodMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.FoodMenus", "Food_Id", "dbo.Foods");
            DropForeignKey("dbo.MenuCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.MenuCustomers", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.ExerciseTrainingPrograms", new[] { "TrainingProgram_Id" });
            DropIndex("dbo.ExerciseTrainingPrograms", new[] { "Exercise_Id" });
            DropIndex("dbo.TrainingProgramCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.TrainingProgramCustomers", new[] { "TrainingProgram_Id" });
            DropIndex("dbo.FoodMenus", new[] { "Menu_Id" });
            DropIndex("dbo.FoodMenus", new[] { "Food_Id" });
            DropIndex("dbo.MenuCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.MenuCustomers", new[] { "Menu_Id" });
            DropTable("dbo.ExerciseTrainingPrograms");
            DropTable("dbo.TrainingProgramCustomers");
            DropTable("dbo.FoodMenus");
            DropTable("dbo.MenuCustomers");
            DropTable("dbo.Exercises");
            DropTable("dbo.TrainingPrograms");
            DropTable("dbo.Foods");
            DropTable("dbo.Menus");
            DropTable("dbo.Customers");
        }
    }
}
