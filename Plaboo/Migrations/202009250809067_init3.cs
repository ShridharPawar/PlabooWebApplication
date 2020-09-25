namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecyclingCentres",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        Suburb = c.String(),
                        Postcode = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RecyclingCentres");
        }
    }
}
