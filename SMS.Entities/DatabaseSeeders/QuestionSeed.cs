using Microsoft.EntityFrameworkCore;

namespace SMS.Entities.DatabaseSeeders
{
    public static class QuestionSeed
    {
        public static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(

            new Question
            {
                QuestionID = 1,
                SurveyID = 1,
                QuestionType = "MultipleChoice",
                IsRequired = true
            },
            new Question
            {
                QuestionID = 2,
                SurveyID = 2,
                QuestionType = "MultipleChoice",
                IsRequired = false
            },
            new Question
            {
                QuestionID = 3,
                SurveyID = 3,
                QuestionType = "Rating",
                IsRequired = true
            });
        }
    }
}
