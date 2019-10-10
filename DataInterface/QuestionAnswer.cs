using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ConsoleApp1;

namespace DataInterface
{
    public class QuestionAnswer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int QuestionAnwID { get; set; }
        public string QuestionAnsText { get; set; }

        public ICollection<TestAnswer> TestAnswers { get; set; }
        public ICollection<AnswerAlt> AnswerAlts { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}
