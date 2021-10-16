namespace BLEpicToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "StrengthExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "MaxStrengthExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "IntelExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "MaxIntelExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "CreativeExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "MaxCreativeExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "HealthExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "MaxHealthExp", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "photo");
            DropColumn("dbo.Users", "MaxHealthExp");
            DropColumn("dbo.Users", "HealthExp");
            DropColumn("dbo.Users", "MaxCreativeExp");
            DropColumn("dbo.Users", "CreativeExp");
            DropColumn("dbo.Users", "MaxIntelExp");
            DropColumn("dbo.Users", "IntelExp");
            DropColumn("dbo.Users", "MaxStrengthExp");
            DropColumn("dbo.Users", "StrengthExp");
        }
    }
}
