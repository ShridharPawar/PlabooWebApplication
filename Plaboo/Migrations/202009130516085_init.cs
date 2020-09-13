namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
            
            CreateTable(
                "dbo.Plastics",
                c => new
                    {
                        Plasticid = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Alternative = c.String(),
                        Reason = c.String(),
                        Image = c.String(),
                        Harmindex = c.Int(nullable: false),
                        Classification = c.String(),
                        HarmMeasure = c.String(),
                    })
                .PrimaryKey(t => t.Plasticid);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        Questionid = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        QuestionImage = c.String(),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                        CorrectAnswer = c.String(),
                        DifficultyLevel = c.String(),
                    })
                .PrimaryKey(t => t.Questionid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quizs");
            DropTable("dbo.Plastics");
            DropTable("dbo.councilRates");
            DropTable("dbo.allCouncilPostcodes");
        }
    }
}
