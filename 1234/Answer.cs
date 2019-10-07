using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Answer
    {
        public int AnswerID { get; set; }

        public ICollection<TestAnswer> TestAnswers { get; set; }
    }
}
