using Coursera_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursera_Project.Data
{
    public class CourseraDbContext : DbContext
    {
        public CourseraDbContext() { }

        public CourseraDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>(x =>
            {
                x.HasKey(x => new { x.StudentPin, x.CourseId });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
