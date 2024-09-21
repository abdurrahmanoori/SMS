using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class QuestionTranslationAddDto
    {
        public int QuestionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string QuestionText { get; set; }

        public QuestionTranslation ToQuestionTranslation()
        {
            return new QuestionTranslation
            {
              LanguageID = LanguageID,
              QuestionText = QuestionText,
              QuestionID = QuestionID,
              
            };
        }
    }
}
