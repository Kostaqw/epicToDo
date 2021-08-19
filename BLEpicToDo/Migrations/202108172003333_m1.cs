namespace BLEpicToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Abilities", "User_UserId", "dbo.Users");
            DropIndex("dbo.Abilities", new[] { "User_UserId" });
            RenameColumn(table: "dbo.Abilities", name: "User_UserId", newName: "UserId");
            AlterColumn("dbo.Abilities", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Abilities", "UserId");
            AddForeignKey("dbo.Abilities", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abilities", "UserId", "dbo.Users");
            DropIndex("dbo.Abilities", new[] { "UserId" });
            AlterColumn("dbo.Abilities", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Abilities", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.Abilities", "User_UserId");
            AddForeignKey("dbo.Abilities", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
