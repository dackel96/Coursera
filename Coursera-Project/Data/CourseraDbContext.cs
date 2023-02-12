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

            //modelBuilder.Entity<StudentCourse>(x =>
            //{
            //    x.HasData(
            //     new StudentCourse { StudentPin = "9412011005", CourseId = 1, CompletionDate = DateTime.Parse("2019-07-16") },
            //     new StudentCourse { StudentPin = "9412011005", CourseId = 2, CompletionDate = DateTime.Parse("2019-08-20") },
            //     new StudentCourse { StudentPin = "9501011014", CourseId = 1, CompletionDate = DateTime.Parse("2019-07-16") },
            //     new StudentCourse { StudentPin = "9501011014", CourseId = 2, CompletionDate = DateTime.Parse("2019-08-01") },
            //     new StudentCourse { StudentPin = "9501011014", CourseId = 3, CompletionDate = DateTime.Parse("2019-10-01") },
            //     new StudentCourse { StudentPin = "9501011014", CourseId = 4, CompletionDate = DateTime.Parse("2019-12-05") },
            //     new StudentCourse { StudentPin = "9507141009", CourseId = 4, CompletionDate = DateTime.Parse("2019-08-20") });

            //});

            base.OnModelCreating(modelBuilder);
        }
    }
}
