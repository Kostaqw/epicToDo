namespace BLEpicToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dailies", "Name", c => c.String());
            AddColumn("dbo.Dailies", "Description", c => c.String());
            AddColumn("dbo.Dailies", "Dificult", c => c.Int(nullable: false));
            AddColumn("dbo.Dailies", "DateComplete", c => c.DateTime(nullable: false));
            AddColumn("dbo.Dailies", "Ability", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dailies", "Ability");
            DropColumn("dbo.Dailies", "DateComplete");
            DropColumn("dbo.Dailies", "Dificult");
            DropColumn("dbo.Dailies", "Description");
            DropColumn("dbo.Dailies", "Name");
        }
    }
}
