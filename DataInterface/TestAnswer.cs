using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataInterface;

namespace ConsoleApp1
{
    public class TestAnswer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestAnswerID { get; set; }
        public int AnswerID { get; set; }
        public int QuestionAnwID{get; set;}


        //public Answer Answer { get; set; }
        public QuestionAnswer QuestionAnswer { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Test> Tests {get; set;}
    }
}
