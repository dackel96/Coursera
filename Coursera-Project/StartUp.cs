﻿using Coursera_Project.Data;
using CsvHelper;
using System.Globalization;

CourseraDbContext context = new CourseraDbContext();
//context.Database.EnsureDeleted();
context.Database.EnsureCreated();


var records = context.Students.ToList();

using (var writer = new StreamWriter("E:\\GitHub\\Coursera\\Coursera\\OutputFiles\\file.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(records);
}

