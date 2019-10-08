using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using DataInterface;

namespace DataAccess
{
    public class TeacherManager : ITeacher
    {
        public void AddTeacher(string name)
        {
            using(var schoolContext = new SchoolContext())
            {
                var teacher1 = new Teacher();
                teacher1.Name = "Göran";
                schoolContext.Teachers.Add(teacher1);

                var teacher2 = new Teacher();
                teacher2.Name = "Maria";
                schoolContext.Teachers.Add(teacher2);
            }
        }
    }

}
