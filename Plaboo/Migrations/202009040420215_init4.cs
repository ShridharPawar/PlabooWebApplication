namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plastics", "Classification", c => c.String());
            AddColumn("dbo.Plastics", "HarmMeasure", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plastics", "HarmMeasure");
            DropColumn("dbo.Plastics", "Classification");
        }
    }
}
