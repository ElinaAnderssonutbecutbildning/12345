using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        public int AnswerAltID { get; set; }

        public string QuestionName { get; set; }

        public AnswerAlt AnswerAlt{get; set;}
        public ICollection<Tests> Tests { get; set; }
    }
}