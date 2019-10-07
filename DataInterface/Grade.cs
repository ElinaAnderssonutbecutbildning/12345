using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Grade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradeID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int TestID { get; set; }
        public string GradeName { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Tests Tests { get; set; }
    }
}