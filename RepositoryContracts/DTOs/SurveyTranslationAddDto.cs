using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyTranslationAddDto
    {
        public string SurveyTranslationDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public SurveyTranslation ToSurveyTranslation()
        {
            return new SurveyTranslation
            {
                SurveyTranslationDescription = SurveyTranslationDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
