using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TestAnswer
    {
        public int TestAnswerID { get; set; }
        public bool TestAnswerRW;

        public ICollection<Question> Questions { get; set; }
    }
}
