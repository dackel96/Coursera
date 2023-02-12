using Coursera_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coursera_Project.Data.DataSeed
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            //builder.HasData(SeedCourses());
        }

        private IEnumerable<Course> SeedCourses()
        {
            var courses = new HashSet<Course>();

            var course = new Course()
            {
                Id = 1,
                Name = "Analysis",
                InstructorId = 1,
                TotalTime = 20,
                Credit = 10,
                TimeCreated = DateTime.Parse("2020-03-16 13:26:44.283")
            };

            courses.Add(course);

            course = new Course()
            {
                Id = 2,
                Name = "Linear Algebra",
                InstructorId = 1,
                TotalTime = 30,
                Credit = 15,
                TimeCreated = DateTime.Parse("2020-03-16 13:27:26.300")
            };

            courses.Add(course);

            course = new Course()
            {
                Id = 3,
                Name = "Statistics",
                InstructorId = 2,
                TotalTime = 30,
                Credit = 15,
                TimeCreated = DateTime.Parse("2020-03-16 13:27:38.417")
            };

            courses.Add(course);

            course = new Course()
            {
                Id = 4,
                Name = "Geometry",
                InstructorId = 3,
                TotalTime = 35,
                Credit = 20,
                TimeCreated = DateTime.Parse("2020-03-16 13:27:54.013")
            };

            courses.Add(course);

            return courses;
        }

    }
}