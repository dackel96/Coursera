using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Coursera_Project.Models.DataConstants;

namespace Coursera_Project.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [StringLength(CourseNameMaxLength)]
        public string Name { get; set; } = null!;

        public byte TotalTime { get; set; }

        public byte Credit { get; set; }

        public DateTime TimeCreated { get; set; }

        public int InstructorId { get; set; }

        [ForeignKey(nameof(InstructorId))]
        public Instructor Instructor { get; set; } = null!;

        public IEnumerable<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
