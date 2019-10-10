using System;
using System.Collections.Generic;
using System.Linq;
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