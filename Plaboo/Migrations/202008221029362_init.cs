namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plastics",
                c => new
                    {
                        Plasticid = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Plasticid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plastics");
        }
    }
}
