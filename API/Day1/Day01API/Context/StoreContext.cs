using Day01API.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Day01API.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
    }
}
