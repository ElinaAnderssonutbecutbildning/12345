using DataInterface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Student : IStudent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        public int TestAnswerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public TestAnswer TestAnswer { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}