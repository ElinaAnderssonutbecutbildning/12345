using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using DataInterface;

namespace DataAccess
{
    public class CourseManager : ICourse
    {
        public void AddCourse(string name)
        {
            using (var schoolContext = new SchoolContext())
            {
                var course = new Course();
                course.Name = name;
                schoolContext.Courses.Add(course);
                schoolContext.SaveChanges();
            }
        }
    }
}