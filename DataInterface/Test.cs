using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestID { get; set; }
        public int QuestionID {get;set;}

        public string TestName { get; set; }

        public Question Question{get; set;}
        public ICollection<Course> Courses{get; set;}
        //public ICollection<Grade> Grades { get; set; } Göras om, ska vara till course ist
    }
}                                                        