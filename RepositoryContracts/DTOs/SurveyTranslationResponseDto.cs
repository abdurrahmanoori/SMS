using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyTranslationResponseDto
    {
        public int SurveyTranslationID { get; set; }
        public int SurveyID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string Title { get; set; }
        public string Description { get; set; }

    }

    public static class SurveyTranslationExtention
    {
        public static SurveyTranslationResponseDto ToSurveyTranslationResponseDto(this SurveyTranslation surveyranslation)
        {
            return new SurveyTranslationResponseDto
            {
              LanguageID = surveyranslation.LanguageID,
              Title = surveyranslation.Title,
              Description = surveyranslation.Description,
              SurveyTranslationID = surveyranslation.SurveyTranslationID,
              SurveyID= surveyranslation.SurveyID

            };
        }
    }
}
