using DataInterface;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class AnswerAlt
    {
        public int AnswerAltID { get; set; }
        public int QuestionAnswerID { get; set; }
        public string AlterText { get; set; }
        
        public QuestionAnswer QuestionAnswer { get; set; }
        public ICollection<Question> Questions { get; set; }
        //public ICollection<Answer> Answers { get; set; }
    }
}