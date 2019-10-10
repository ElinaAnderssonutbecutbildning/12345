using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerID { get; set; }
        public int AnswerAltID { get; set; }
        public AnswerAlt AnswerAlt { get; set; }
        public ICollection<TestAnswer> TestAnswers { get; set; }
    }
}