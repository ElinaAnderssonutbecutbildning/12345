using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class QuestionAnswer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionAnswerID { get; set; }

        public int SelectedAnswer { get; set; }

        public ICollection<TestAnswer> TestAnswers { get; set; }
        public ICollection<AnswerAlt> AnswerAlts { get; set; }
        public ICollection<Question> Questions { get; set; } // Why?
    }
}