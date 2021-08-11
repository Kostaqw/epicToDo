namespace BLEpicToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        AbilityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        attribute = c.Int(nullable: false),
                        TaskId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AbilityId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dificult = c.Int(nullable: false),
                        notification = c.Boolean(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        UserId = c.Int(nullable: false),
                        AbilityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abilities", t => t.AbilityId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.AbilityId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Level = c.Int(nullable: false),
                        Exp = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        Intelect = c.Int(nullable: false),
                        Creative = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Achives",
                c => new
                    {
                        AchiveId = c.Int(nullable: false, identity: true),
                        Describe = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AchiveId);
            
            CreateTable(
                "dbo.Dailies",
                c => new
                    {
                        DailyId = c.Int(nullable: false, identity: true),
                        DateCreate = c.DateTime(nullable: false),
                        notification = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DailyId);
            
            CreateTable(
                "dbo.AchiveUsers",
                c => new
                    {
                        Achive_AchiveId = c.Int(nullable: false),
                        User_UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Achive_AchiveId, t.User_UserId })
                .ForeignKey("dbo.Achives", t => t.Achive_AchiveId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .Index(t => t.Achive_AchiveId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "UserId", "dbo.Users");
            DropForeignKey("dbo.AchiveUsers", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.AchiveUsers", "Achive_AchiveId", "dbo.Achives");
            DropForeignKey("dbo.Abilities", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tasks", "AbilityId", "dbo.Abilities");
            DropIndex("dbo.AchiveUsers", new[] { "User_UserId" });
            DropIndex("dbo.AchiveUsers", new[] { "Achive_AchiveId" });
            DropIndex("dbo.Tasks", new[] { "AbilityId" });
            DropIndex("dbo.Tasks", new[] { "UserId" });
            DropIndex("dbo.Abilities", new[] { "UserId" });
            DropTable("dbo.AchiveUsers");
            DropTable("dbo.Dailies");
            DropTable("dbo.Achives");
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.Abilities");
        }
    }
}
