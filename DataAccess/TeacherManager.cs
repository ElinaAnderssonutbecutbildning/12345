using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using DataInterface;

namespace DataAccess
{
    public class TeacherManager : ITeacher
    {
        public void AddTeacher(string teacherName)
        {
            using(var schoolContext = new SchoolContext())
            {
                var teacher = new Teacher();
                teacher.Name = teacherName;
                schoolContext.Teachers.Add(teacher);
                schoolContext.SaveChanges();
            }
        }
    }
}