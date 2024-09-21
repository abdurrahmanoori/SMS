using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionTranslationAddDto
    {
        public int AnswerOptionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        //This about this.
        public string AnswerOptionText { get; set; }
        public AnswerOptionTranslation ToAnswerOptionTranslation()
        {
            return new AnswerOptionTranslation
            {
                AnswerOptionID = AnswerOptionID,
                LanguageID = LanguageID, 
                AnswerOptionText = AnswerOptionText,
            };
        }
    }
}
