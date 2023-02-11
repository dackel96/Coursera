using System.ComponentModel.DataAnnotations;

using static Coursera_Project.Models.StudentConstants;

namespace Coursera_Project.Models
{
    public class Student
    {
        [Key]
        [StringLength(StudentPinMaxLength)]
        public string Pin { get; set; } = null!;

        [StringLength(StudentFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [StringLength(StudentLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public DateTime TimeCreated { get; set; }
    }
}
