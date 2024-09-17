using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceQuestionAddDto
    {
        public string SurveyInstanceQuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public SurveyInstanceQuestion ToSurveyInstanceQuestion()
        {
            return new SurveyInstanceQuestion
            {
                SurveyInstanceQuestionDescription = SurveyInstanceQuestionDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
