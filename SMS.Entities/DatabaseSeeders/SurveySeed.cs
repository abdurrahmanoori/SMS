using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class SurveySeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Survey>().HasData(
             new Survey
             {
                 SurveyID = 1,
                 SurveyDescription = "Customer Satisfaction Survey",
                 CreatedDate = new DateTime(2021, 2, 1), // Sets the date to October 1, 2023
                 IsActive = true
             },
            new Survey
            {
                SurveyID = 2,
                SurveyDescription = "Customer Satisfaction Survey",
                CreatedDate = new DateTime(2021, 11, 1), // Sets the date to October 1, 2023
                IsActive = true
            },
            new Survey
            {
                SurveyID = 3,
                SurveyDescription = "Customer Satisfaction Survey",
                CreatedDate = new DateTime(2022, 3, 1), // Sets the date to October 1, 2023
                IsActive = true

            },
            new Survey
            {
                SurveyID = 4,
                SurveyDescription = "Customer Satisfaction Survey",
                CreatedDate = new DateTime(2023, 6, 1), // Sets the date to October 1, 2023
                IsActive = true

            },
            new Survey
            {
                SurveyID = 1,
                SurveyDescription = "Customer Satisfaction Survey",
                CreatedDate = new DateTime(2024, 9, 1), // Sets the date to October 1, 2023
                IsActive = true

            }
        );
        }
    }
}
