using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Project.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public byte TotalTime { get; set; }

        public byte Credit { get; set; }

        public DateTime TimeCreated { get; set; }

        public int InstructorId { get; set; }

        [ForeignKey(nameof(InstructorId))]
        public Instructor Instructor { get; set; } = null!;
    }
}
