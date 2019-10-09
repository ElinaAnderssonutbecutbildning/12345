namespace ConsoleApp1
{
    public class CourseManager : ICourse
    {
        public void AddCourse(string courseName, Teacher teacherName)
        {
            using (var schoolContext = new SchoolContext())
            {
                var course = new Course
                {
                    Name = courseName,
                    Teacher = teacherName
                };
                schoolContext.Courses.Add(course);
                schoolContext.SaveChanges();
            }
        }
    }
}