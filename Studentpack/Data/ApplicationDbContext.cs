using Microsoft.EntityFrameworkCore;
using Studentpack.Models;

namespace Studentpack.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<SchoolClass> schoolClass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1980, 1, 1), Email = "john.doe@example.com", PhoneNumber = "1234567890" },
                new Teacher { TeacherId = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1985, 2, 2), Email = "jane.smith@example.com", PhoneNumber = "0987654321" }
            );

            // Seed data for SchoolClasses
            modelBuilder.Entity<SchoolClass>().HasData(
                new SchoolClass { ClassId = 1, ClassName = "Math 101", Description = "Basic Math Class", TeacherId = 1 },
                new SchoolClass { ClassId = 2, ClassName = "Science 101", Description = "Basic Science Class", TeacherId = 2 }
            );

            // Seed data for Students
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(2005, 3, 3), Email = "alice.johnson@example.com", ClassId = 1 },
                new Student { StudentId = 2, FirstName = "Bob", LastName = "Brown", DateOfBirth = new DateTime(2006, 4, 4), Email = "bob.brown@example.com", ClassId = 2 }
            );
        }


    }
}
