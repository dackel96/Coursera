using System.ComponentModel.DataAnnotations;

namespace Coursera_Project.Models
{
    public class StudentCourse
    {
        public string StudentPin { get; set; } = null!;

        public int CourseId { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}
