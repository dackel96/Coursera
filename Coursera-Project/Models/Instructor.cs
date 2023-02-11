using System.ComponentModel.DataAnnotations;

namespace Coursera_Project.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime TimeCreated { get; set; }
    }
}
