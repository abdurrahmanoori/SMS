using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceQuestionAddDto
    {
        public int SurveyInstanceID { get; set; }
        public int QuestionID { get; set; }

        public SurveyInstanceQuestion ToSurveyInstanceQuestion()
        {
            return new SurveyInstanceQuestion
            {
               QuestionID = QuestionID,
               SurveyInstanceID = SurveyInstanceID,
            };
        }
    }
}
