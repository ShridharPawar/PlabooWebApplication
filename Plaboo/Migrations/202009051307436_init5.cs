namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.allCouncilPostcodes",
                c => new
                    {
                        postcode = c.String(nullable: false, maxLength: 128),
                        council = c.String(),
                    })
                .PrimaryKey(t => t.postcode);
            
            CreateTable(
                "dbo.councilRates",
                c => new
                    {
                        council = c.String(nullable: false, maxLength: 128),
                        rate = c.String(),
                        rank = c.String(),
                    })
                .PrimaryKey(t => t.council);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.councilRates");
            DropTable("dbo.allCouncilPostcodes");
        }
    }
}
