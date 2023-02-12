using System.ComponentModel.DataAnnotations;
using static Coursera_Project.Models.InstructorConstants;

namespace Coursera_Project.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(InstructorFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [StringLength(InstructorLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public DateTime TimeCreated { get; set; }
    }
}
