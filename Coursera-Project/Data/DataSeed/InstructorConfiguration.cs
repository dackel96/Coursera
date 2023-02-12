using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Coursera_Project.Models;

namespace Coursera_Project.Data.DataSeed
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            //builder.HasData(SeedInstructors());
        }

        private IEnumerable<Instructor> SeedInstructors()
        {
            var instructors = new HashSet<Instructor>();

            var instructor = new Instructor()
            {
                Id = 1,
                FirstName = "Neno",
                LastName = "Dimitrov",
                TimeCreated = DateTime.Parse("2020-03-16 13:25:34.973")
            };

            instructors.Add(instructor);

            instructor = new Instructor()
            {
                Id = 2,
                FirstName = "Petko",
                LastName = "Valchev",
                TimeCreated = DateTime.Parse("2020-03-16 13:26:00.143")
            };

            instructors.Add(instructor);

            instructor = new Instructor()
            {
                Id = 3,
                FirstName = "Petar",
                LastName = "Penchev",
                TimeCreated = DateTime.Parse("2020-03-16 13:26:12.613")
            };

            instructors.Add(instructor);

            return instructors;
        }
    }
}


