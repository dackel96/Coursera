namespace Coursera_Project.DataProcessor.ExportDTO
{
    public class StudentInformation
    {
        public string FullName { get; set; } = null!;

        public int TotalCredits { get; set; }

        public string CourseName { get; set; } = null!;

        public int Time { get; set; }

        public int CreditForCourse { get; set; }

        public string InstructorName { get; set; } = null!;
    }
}
