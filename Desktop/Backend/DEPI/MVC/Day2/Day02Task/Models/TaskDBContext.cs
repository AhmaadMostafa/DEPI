using Microsoft.EntityFrameworkCore;

namespace Day02Task.Models
{
    public class TaskDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DepiDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Student>Student {  get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseResult> CourseResult { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
