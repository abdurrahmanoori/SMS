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
                SurveyID = 101,
                QuestionType = "MultipleChoice",
                IsRequired = true
            },
            new Question
            {
                QuestionID = 2,
                SurveyID = 101,
                QuestionType = "MultipleChoice",
                IsRequired = false
            },
            new Question
            {
                QuestionID = 3,
                SurveyID = 102,
                QuestionType = "Rating",
                IsRequired = true
            },
            new Question
            {
                QuestionID = 4,
                SurveyID = 103,
                QuestionType = "Text",
                IsRequired = true
            },
            new Question
            {
                QuestionID = 5,
                SurveyID = 103,
                QuestionType = "Text",
                IsRequired = false
            },
            new Question
            {
                QuestionID = 6,
                SurveyID = 104,
                QuestionType = "YesNo",
                IsRequired = true
            },
            new Question
            {
                QuestionID = 7,
                SurveyID = 105,
                QuestionType = "MultipleChoice",
                IsRequired = true
            });
        }
    }
}
