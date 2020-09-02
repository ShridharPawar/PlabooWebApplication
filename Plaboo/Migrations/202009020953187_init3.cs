namespace Plaboo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Questionid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quizs");
        }
    }
}
