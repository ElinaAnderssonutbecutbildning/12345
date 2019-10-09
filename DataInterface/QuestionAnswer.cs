using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace DataInterface
{
    public class QuestionAnswer
    {
        public int QuestionAnwID { get; set; }
        public string QuestionAnsText { get; set; }

        public ICollection<TestAnswer> TestAnswers { get; set; }
        public ICollection<AnswerAlt> AnswerAlts { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}
