namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RecyclingCentres", "DetailedAddress", c => c.String());
            AddColumn("dbo.RecyclingCentres", "Contact", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RecyclingCentres", "Contact");
            DropColumn("dbo.RecyclingCentres", "DetailedAddress");
        }
    }
}
