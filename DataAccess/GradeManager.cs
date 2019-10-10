namespace ConsoleApp1
{
    class GradeManager : IGrade
    {
        public void AddGrade(string GradeName)
        {
            using (var schoolContext = new SchoolContext())
            {
                var grade = new Grade
                {
                    GradeName = GradeName
                };
                schoolContext.Grades.Add(grade);
            }
        }
    }
}
