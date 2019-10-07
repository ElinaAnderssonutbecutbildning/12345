using System.Collections.Generic;

namespace ConsoleApp1
{
    public class AnswerAlt
    {
        public int AnswerAltID { get; set; }
        public string AlterText { get; set; }
        public bool AltRorW;
        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}