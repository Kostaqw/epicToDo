namespace BLEpicToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        AbilityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Level = c.Int(nullable: false),
                        Exp = c.Int(nullable: false),
                        MaxExp = c.Int(nullable: false),
                        attribute = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.AbilityId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Level = c.Int(nullable: false),
                        Exp = c.Int(nullable: false),
                        MaxExp = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        Intelect = c.Int(nullable: false),
                        Creative = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Dailies",
                c => new
                    {
                        DailyId = c.Int(nullable: false, identity: true),
                        DateCreate = c.DateTime(nullable: false),
                        notification = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DailyId)
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Dailies", "UserId", "dbo.Users");
            DropForeignKey("dbo.Abilities", "User_UserId", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "UserId" });
            DropIndex("dbo.Dailies", new[] { "UserId" });
            DropIndex("dbo.Abilities", new[] { "User_UserId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Dailies");
            DropTable("dbo.Users");
            DropTable("dbo.Abilities");
        }
    }
}
