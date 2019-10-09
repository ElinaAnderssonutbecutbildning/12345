using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class TestAnswer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestAnswerID { get; set; }
        public int QuestionAnswerID { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Test> Tests { get; set; }

        public QuestionAnswer QuestionAnswer { get; set; }
    }
}
