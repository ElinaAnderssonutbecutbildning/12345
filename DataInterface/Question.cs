using DataInterface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        public int AnswerAltID { get; set; }
        public int QuestionAnswerID { get; set; }

        public string QuestionText { get; set; }

        public ICollection<Test> Tests { get; set; }

        public AnswerAlt AnswerAlt { get; set; }
        public QuestionAnswer QuestionAnswer { get; set; }
    }
}