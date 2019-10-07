using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class SchoolContext : DbContext
    {
        private const string connectinString = "server=LAPTOP-UIJVU0KV;Database=EFCore;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectinString);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}