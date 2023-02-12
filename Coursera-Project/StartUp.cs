using Coursera_Project.Data;

CourseraDbContext context = new CourseraDbContext();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();