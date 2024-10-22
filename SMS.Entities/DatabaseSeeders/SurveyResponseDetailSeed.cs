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
                FreeTextAnswer = "I believe online learning offers flexibility and accessibility, but it can lack the personal interaction and engagement found in traditional classrooms."

            },
            new SurveyResponseDetail
            {
                SurveyResponseDetailID = 2,
                SurveyResponseID = 2,
                SurveyInstanceQuestionID = 2,
                AnswerOptionID = 2,
                FreeTextAnswer = "I am passionate about sustainable practices and believe this company aligns with my values and career goals."

            },
            new SurveyResponseDetail
            {
                SurveyResponseDetailID = 3,
                SurveyResponseID = 3,
                SurveyInstanceQuestionID = 3,
                AnswerOptionID = 3,
                FreeTextAnswer = "Traveling abroad taught me about different cultures and perspectives, which greatly expanded my worldview."
            });
        }
    }
}
