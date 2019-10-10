using System.Collections.Generic;
using DataInterface;

namespace ConsoleApp1
{
    public class TestAnswer
    {
        public int TestAnswerID { get; set; }
        public int AnswerID { get; set; }
        public int QuestionAnwID{get; set;}


        public Answer Answer { get; set; }
        public QuestionAnswer QuestionAnswer { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Test> Tests {get; set;}
    }
}
