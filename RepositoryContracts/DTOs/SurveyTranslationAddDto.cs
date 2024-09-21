using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyTranslationAddDto
    {
        public int SurveyID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string Title { get; set; }
        public string Description { get; set; }


        public SurveyTranslation ToSurveyTranslation()
        {
            return new SurveyTranslation
            {
                SurveyID = SurveyID, 
                LanguageID = LanguageID,
                Title = Title,
                Description = Description
            };
        }
    }
}
