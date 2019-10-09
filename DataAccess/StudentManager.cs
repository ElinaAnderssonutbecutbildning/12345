using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using DataInterface;

namespace DataAccess
{
    
    public class StudentManager : IStudent
    {
        public void AddStudent(string name, int age)
        {
            using (var schoolContext = new SchoolContext())
            {
                var student = new Student();
                student.Name = name;
                student.Age = age;
                schoolContext.StudentS.Add(student);
                schoolContext.SaveChanges();
            }
        }
    }
}
