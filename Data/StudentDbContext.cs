using Lab6_1_.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_1_.Data
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
            public DbSet<Student> Students { get; set;  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
        }
        
    }
}
