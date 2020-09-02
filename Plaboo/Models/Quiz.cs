using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plaboo.Models
{
    public class Quiz
    {

        [Key]
        public int Questionid { get; set; }
        public string Question { get; set; }

        public string QuestionImage { get; set; }

        public string OptionA { get; set; }

        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }

        public string CorrectAnswer { get; set; }
    }
}