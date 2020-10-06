namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            //DropTable("dbo.RecyclingCentres");
        }
        
        public override void Down()
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
                        DetailedAddress = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
    }
}
