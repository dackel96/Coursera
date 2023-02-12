using Coursera_Project.Data;
using Coursera_Project.DataProcessor.ExportDTO;
using CsvHelper;
using System.Globalization;

CourseraDbContext context = new CourseraDbContext();
//context.Database.EnsureDeleted();
context.Database.EnsureCreated();


var records = new List<StudentInformation>();

records = context.Students
    .Select(x => new StudentInformation()
    {
        FullName = $"{x.FirstName} {x.LastName}"
    })
    .ToList();

using (var writer = new StreamWriter("E:\\GitHub\\Coursera\\Coursera\\OutputFiles\\file.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(records);
}

