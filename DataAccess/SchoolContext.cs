using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class SchoolContext : DbContext
    {
        private const string connectinString = "Server=localhost;Database=EFCore;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectinString);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerAlt> AnswerAlts { get; set; }
        public DbSet<TestAnswer> TestAnswers { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    }
}