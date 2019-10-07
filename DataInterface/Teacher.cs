using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherID { get; set; }
        public int CourseID { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
