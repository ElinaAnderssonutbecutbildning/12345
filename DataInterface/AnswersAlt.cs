using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class AnswerAlt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerAltID { get; set; }
        public int QuestionAnswerID { get; set; }

        public string[] AnswerAlternatives { get; set; }
        public int CorrectAlternativeIndex { get; set; }

        public ICollection<Question> Questions { get; set; }

        public QuestionAnswer QuestionAnswer { get; set; }
    }
}