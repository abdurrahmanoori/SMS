using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class RespondentSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Respondent>().HasData(
            new Respondent
            {
                RespondentID = 1,
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                DateOfBirth = 1990, // Consider changing this to a DateTime if appropriate
                Province = "Ontario",
                EducationLevel = "Bachelor's",
                Name = "John Doe"
            },
            new Respondent
            {
                RespondentID = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Gender = "Female",
                Email = "jane.smith@example.com",
                PhoneNumber = "098-765-4321",
                DateOfBirth = 1985, // Consider changing this to a DateTime if appropriate
                Province = "Quebec",
                EducationLevel = "Master's",
                Name = "Jane Smith"
            },
            new Respondent
            {
                RespondentID = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                Gender = "Female",
                Email = "alice.johnson@example.com",
                PhoneNumber = "555-123-4567",
                DateOfBirth = 1992, // Consider changing this to a DateTime if appropriate
                Province = "British Columbia",
                EducationLevel = "PhD",
                Name = "Alice Johnson"
            },
            new Respondent
            {
                RespondentID = 4,
                FirstName = "Bob",
                LastName = "Brown",
                Gender = "Male",
                Email = "bob.brown@example.com",
                PhoneNumber = "555-765-4321",
                DateOfBirth = 1988, // Consider changing this to a DateTime if appropriate
                Province = "Alberta",
                EducationLevel = "Diploma",
                Name = "Bob Brown"
            });
        }
    }
}
