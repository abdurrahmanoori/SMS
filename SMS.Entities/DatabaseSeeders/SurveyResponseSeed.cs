using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class SurveyResponseSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyResponse>().HasData(
            new SurveyResponse
            {
                 SurveyResponseID = 1,
                 SurveyInstanceID = 1,
                 RespondentID = 1,
                 ResponseDate = DateTime.UtcNow
            },
            new SurveyResponse
            {
                SurveyResponseID = 2,
                SurveyInstanceID = 2,
                RespondentID = 2,
                ResponseDate = DateTime.UtcNow.AddDays(-1)
            },
            new SurveyResponse
            {
                SurveyResponseID = 3,
                SurveyInstanceID = 3,
                RespondentID = 3,
                ResponseDate = DateTime.UtcNow.AddDays(-2)
            });
        }
    }
}
