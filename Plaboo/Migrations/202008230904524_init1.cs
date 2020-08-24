namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plastics", "Alternative", c => c.String());
            AddColumn("dbo.Plastics", "Reason", c => c.String());
            AddColumn("dbo.Plastics", "Image", c => c.String());
            AddColumn("dbo.Plastics", "Harmindex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plastics", "Harmindex");
            DropColumn("dbo.Plastics", "Image");
            DropColumn("dbo.Plastics", "Reason");
            DropColumn("dbo.Plastics", "Alternative");
        }
    }
}
