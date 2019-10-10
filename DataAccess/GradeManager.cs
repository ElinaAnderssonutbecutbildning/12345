using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using DataInterface;

namespace DataAccess
{
    class GradeManager : IGrade
    {

        public void AddGrade(string GradeName)
        {
            using (var schoolContext = new SchoolContext())
            {
                var grade = new Grade();
                grade.GradeName = GradeName;
                schoolContext.Grades.Add(grade);
            }
        }
    }
}
