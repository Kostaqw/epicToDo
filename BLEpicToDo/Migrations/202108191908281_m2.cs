namespace BLEpicToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "complite", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tasks", "Ability", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Ability");
            DropColumn("dbo.Tasks", "complite");
        }
    }
}
