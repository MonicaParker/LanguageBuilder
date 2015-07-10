namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraTestRunes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Runes", "Locked", c => c.Boolean(nullable: false));
            DropColumn("dbo.Runes", "LetterPassive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Runes", "LetterPassive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Runes", "Locked");
        }
    }
}
