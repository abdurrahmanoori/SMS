using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class SurveyResponseDetailSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyResponseDetail>().HasData(
            new SurveyResponseDetail
            {
                SurveyResponseDetailID = 1,
                SurveyResponseID = 1,
                SurveyInstanceQuestionID = 1,
                AnswerOptionID = 1,
                FreeTextAnswer = null // Assuming this is a multiple-choice question
            },
            new SurveyResponseDetail
            {
                SurveyResponseDetailID = 2,
                SurveyResponseID = 1,
                SurveyInstanceQuestionID = 2,
                AnswerOptionID = null, // Assuming this is an open-ended question
                FreeTextAnswer = "This is my answer to the open-ended question."
            },
            new SurveyResponseDetail
            {
                SurveyResponseDetailID = 3,
                SurveyResponseID = 2,
                SurveyInstanceQuestionID = 1,
                AnswerOptionID = 2,
                FreeTextAnswer = null // Another multiple-choice answer
            });
        }
    }
}
