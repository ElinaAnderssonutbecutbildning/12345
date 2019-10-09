using DataInterface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public int TeacherID { get; set; }
        public int TestID{get; set;}

        public int Room { get; set; }

        public Test Test {get; set;}
        public Teacher Teacher { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}