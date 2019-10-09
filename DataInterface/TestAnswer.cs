using System.Collections.Generic;

namespace ConsoleApp1
{
    public class TestAnswer
    {
        public int TestAnswerID { get; set; }
        public int AnswerID { get; set; }
        //public int QuestionAnswID{get; set;}

        //public QuestionAnsw QuestionAnsw {get; set;}

        //public Answer Answer { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Test> Tests {get; set;}
    }
}
