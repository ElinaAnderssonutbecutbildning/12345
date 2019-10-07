using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        public int TestAnswerID { get; set; }
        public string Questionname { get; set; }

        public TestAnswer TestAnswer { get; set; }
        public ICollection<Tests> Testss { get; set; }
    }
}

