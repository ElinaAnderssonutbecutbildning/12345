using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public int AnswerAltID { get; set; }
        public AnswerAlt AnswerAlt { get; set; }
        public ICollection<TestAnswer> TestAnswers { get; set; }
    }
}
