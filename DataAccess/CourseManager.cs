using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using DataInterface;

namespace DataAccess
{
    public class CourseManager : ICourse
    {
        public void AddCourse(string courseName, Teacher teacherName )
        {
            using (var schoolContext = new SchoolContext())
            {
                var course = new Course();
                course.Name = courseName;
                course.Teacher = teacherName;
                schoolContext.Courses.Add(course);
                schoolContext.SaveChanges();
            }
        }
    }
}