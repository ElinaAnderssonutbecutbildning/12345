using DataInterface;

namespace ConsoleApp1
{
    public class TeacherManager : ITeacher
    {
        public void AddTeacher(string teacherName)
        {
            using (var schoolContext = new SchoolContext())
            {
                var teacher = new Teacher
                {
                    Name = teacherName
                };
                schoolContext.Teachers.Add(teacher);
                schoolContext.SaveChanges();
            }
        }
    }
}