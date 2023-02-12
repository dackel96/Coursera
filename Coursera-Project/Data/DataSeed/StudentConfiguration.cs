using Coursera_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coursera_Project.Data.DataSeed
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //builder.HasData(SeedStudents());
        }

        private IEnumerable<Student> SeedStudents()
        {
            var students = new HashSet<Student>();

            var student = new Student()
            {
                Pin = "9412011005",
                FirstName = "Krasimir",
                LastName = "Petrov",
                TimeCreated = DateTime.Parse("2020-03-16 13:23:58.777")
            };

            students.Add(student);

            student = new Student()
            {
                Pin = "9501011014",
                FirstName = "Elena",
                LastName = "Foteva",
                TimeCreated = DateTime.Parse("2020-03-16 13:24:29.853")
            };

            students.Add(student);

            student = new Student()
            {
                Pin = "9507141009",
                FirstName = "Ivan",
                LastName = "Ivanov",
                TimeCreated = DateTime.Parse("2020-03-16 13:23:39.220")
            };

            students.Add(student);

            return students;
        }
    }
}