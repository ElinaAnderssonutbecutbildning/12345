using DataInterface;
using System.Linq;

namespace ConsoleApp1
{
    public class StudentManager : IStudent
    {
        public void AddStudent(string studentName, int studentAge)
        {
            using (var schoolContext = new SchoolContext())
            {
                var student = new Student
                {
                    Name = studentName,
                    Age = studentAge
                };
                schoolContext.Students.Add(student);
                schoolContext.SaveChanges();
            }
        }

        public Student GetStudentByID(int studentID)
        {
            using (var schoolContext = new SchoolContext())
            {
                return schoolContext.Students.First(i => i.StudentID == studentID);
            }
        }
    }
}