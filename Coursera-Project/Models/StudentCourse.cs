using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Project.Models
{
    public class StudentCourse
    {
        public string StudentPin { get; set; } = null!;

        public int CourseId { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}
