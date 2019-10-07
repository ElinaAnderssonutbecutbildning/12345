using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hej
            using (var schoolContext = new SchoolContext())
            {
                var teacher1 = new Teacher();
                teacher1.Name = "Göran";
                schoolContext.Teachers.Add(teacher1);

                var teacher2 = new Teacher();
                teacher2.Name = "Maria";
                schoolContext.Teachers.Add(teacher2);

                var Course1 = new Course();
                Course1.Name = "NO";
                Course1.Room = 10;
                Course1.Teacher = teacher1;
                schoolContext.Courses.Add(Course1);


                var Course2 = new Course();
                Course2.Name = "SV";
                Course2.Room = 20;
                Course2.Teacher = teacher2;
                schoolContext.Courses.Add(Course2);


                var Course3 = new Course();
                Course3.Name = "SO";
                Course3.Room = 30;
                Course3.Teacher = teacher2;
                schoolContext.Courses.Add(Course3);


                var Course4 = new Course();
                Course4.Name = "Bild";
                Course4.Room = 40;
                Course4.Teacher = teacher2;
                schoolContext.Courses.Add(Course4);

                var student1 = new Student();
                student1.Name = "Fredrik";
                student1.Age = 32;
                schoolContext.Students.Add(student1);


                var student2 = new Student();
                student2.Name = "Gustaf";
                student2.Age = 35;
                schoolContext.Students.Add(student2);


                var student3 = new Student();
                student3.Name = "Sune";
                student3.Age = 37;
                schoolContext.Students.Add(student3);


                var student4 = new Student();
                student4.Name = "Bert";
                student4.Age = 25;
                schoolContext.Students.Add(student4);


                var student5 = new Student();
                student5.Name = "Sandra";
                student5.Age = 29;
                schoolContext.Students.Add(student5);


                var student6 = new Student();
                student6.Name = "Julia";
                student6.Age = 20;
                schoolContext.Students.Add(student6);


                var student7 = new Student();
                student7.Name = "Viktor";
                student7.Age = 24;
                schoolContext.Students.Add(student7);


                var student8 = new Student();
                student8.Name = "Carl";
                student8.Age = 27;
                schoolContext.Students.Add(student8);


                var student9 = new Student();
                student9.Name = "Peter";
                student9.Age = 28;
                schoolContext.Students.Add(student9);


                var student10 = new Student();
                student10.Name = "Oscar";
                student10.Age = 38;
                schoolContext.Students.Add(student10);


                var student11 = new Student();
                student11.Name = "Elina";
                student11.Age = 27;
                schoolContext.Students.Add(student11);


                var student12 = new Student();
                student12.Name = "Noah";
                student12.Age = 40;
                schoolContext.Students.Add(student12);



                var grade1 = new Grade();
                grade1.Course = Course1;
                grade1.GradeName = "VG";
                grade1.Student = student1;
                schoolContext.Grades.Add(grade1);

                var grade2 = new Grade();
                grade2.Course = Course2;
                grade2.GradeName = "G";
                grade2.Student = student1;
                schoolContext.Grades.Add(grade2);


                var grade3 = new Grade();
                grade3.Course = Course1;
                grade3.GradeName = "VG";
                grade3.Student = student2;
                schoolContext.Grades.Add(grade3);

                var grade4 = new Grade();
                grade4.GradeName = "MVG";
                grade4.Course = Course2;
                grade4.Student = student2;
                schoolContext.Grades.Add(grade4);

                var grade5 = new Grade();
                grade5.Course = Course3;
                grade5.GradeName = "VG";
                grade5.Student = student2;
                schoolContext.Grades.Add(grade5);

                var grade6 = new Grade();
                grade6.GradeName = "G";
                grade6.Course = Course1;
                grade6.Student = student3;
                schoolContext.Grades.Add(grade6);

                var grade7 = new Grade();
                grade7.GradeName = "MVG";
                grade7.Course = Course3;
                grade7.Student = student3;
                schoolContext.Grades.Add(grade7);

                var grade8 = new Grade();
                grade8.GradeName = "G";
                grade8.Course = Course3;
                grade8.Student = student4;
                schoolContext.Grades.Add(grade8);

                var grade9 = new Grade();
                grade9.GradeName = "VG";
                grade9.Course = Course3;
                grade9.Student = student4;
                schoolContext.Grades.Add(grade9);

                var grade10 = new Grade();
                grade10.GradeName = "MVG";
                grade10.Course = Course3;
                grade10.Student = student4;
                schoolContext.Grades.Add(grade10);


                var grade11 = new Grade();
                grade11.GradeName = "G";
                grade11.Course = Course1;
                grade11.Student = student5;
                schoolContext.Grades.Add(grade11);

                var grade12 = new Grade();
                grade12.GradeName = "MVG";
                grade12.Course = Course2;
                grade12.Student = student5;
                schoolContext.Grades.Add(grade12);
                schoolContext.SaveChanges();



                var StudentsInCourseOne = (from s in schoolContext.Students
                                           join g in schoolContext.Grades
                                            on s.StudentID equals g.StudentID
                                           join c in schoolContext.Courses
                                           on g.CourseID equals c.CourseID
                                           where c.Name == "Kurs"
                                           select s);

                var HowManyStudyNO = (from s in schoolContext.Students
                                      join g in schoolContext.Grades
                                       on s.StudentID equals g.StudentID
                                      join c in schoolContext.Courses
                                      on g.CourseID equals c.CourseID
                                      where c.Room == 10
                                      select s);

                var HowManyOver30 = (from s in schoolContext.Students
                                     join g in schoolContext.Grades
                                      on s.StudentID equals g.StudentID
                                     join c in schoolContext.Courses
                                     on g.CourseID equals c.CourseID
                                     where s.Age >= 30
                                     select s);

                var TeacherMostClasses = (
                                          from g in (from c in schoolContext.Courses
                                          group c by c.TeacherID into r
                                          select new { Key = r.Key, Count = r.Count() })
                                          join t in schoolContext.Teachers
                                          on g.Key equals t.TeacherID
                                          orderby g.Count descending
                                          select new { Count = g.Count, Teacher = t.Name }).First();

                var youngestStudentInEachCourse = 
                    (from ages in
                                                   (from s in schoolContext.Students
                                                   join g in schoolContext.Grades
                                                   on s.StudentID equals g.StudentID
                                                   group s by g.CourseID into sc
                                                   select new { CourseID = sc.Key, 
                                                   YougestAge = sc.Min(s => s.Age) })
                     join c in schoolContext.Courses
                     on ages.CourseID equals c.CourseID
                     join s in schoolContext.Students
                     on ages.YougestAge equals s.Age
                     select new { Course = c.Name, StudentName = s.Name });

                var StudentsGradesCourses = (from c in schoolContext.Courses
                                             join g in schoolContext.Grades
                                              on c.CourseID equals g.CourseID
                                             join s in schoolContext.Students
                                             on g.StudentID equals s.StudentID
                                             orderby s.Name
                                             select new { Course = c.Name, StudentName = s.Name,
                                             Grade = g.GradeName });

                Console.WriteLine(" Betyg i kurser");
                foreach ( var S in StudentsGradesCourses)
                    Console.WriteLine(S.Course + " " + S.StudentName + " " + S.Grade);
                Console.ReadLine();

                Console.WriteLine("Vilken elev är yngst i varje kurs?");
                foreach (var studentInClass in youngestStudentInEachCourse)
                    Console.WriteLine(studentInClass.Course + " " + studentInClass.StudentName);
                Console.ReadLine();

                Console.WriteLine("Vilken lärare har mest kurser?");
                    Console.WriteLine(TeacherMostClasses.Teacher + ":" + TeacherMostClasses.Count);
                Console.ReadLine();

                Console.WriteLine("Hur många studerar NO?");
                                foreach (var studentInClass in HowManyStudyNO)
                                    Console.WriteLine(studentInClass.Name);
                                Console.ReadLine();

                                Console.WriteLine("Hur många är/över 30 år");
                                foreach (var studentInClass in HowManyOver30)
                                    Console.WriteLine(studentInClass.Name);
                                Console.ReadLine();

                                foreach ( var studentInClass in StudentsInCourseOne )
                                    Console.WriteLine(studentInClass);
                                Console.ReadLine();
                                
                                var students = schoolContext.Courses.
                                Include(c => c.Grades).
                                ThenInclude(g => g.Student).
                                Where(c => c.Name == "Kurs").                                
                                SelectMany(c => c.Grades.Select(g => g.Student));

                                foreach ( var c in students)
                                    Console.WriteLine(c.Name);
                                Console.ReadLine();



            }

        }
    }
}