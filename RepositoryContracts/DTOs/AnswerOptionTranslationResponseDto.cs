using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionTranslationResponseDto
    {
        public int AnswerOptionTranslationID { get; set; }
        public int AnswerOptionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        //This about this.
        public string AnswerOptionText { get; set; }
    }

    public static class AnswerOptionTranslationExtention
    {
        public static AnswerOptionTranslationResponseDto ToAnswerOptionTranslationResponseDto(this AnswerOptionTranslation answeroptiontranslation)
        {
            return new AnswerOptionTranslationResponseDto
            {
                AnswerOptionTranslationID = answeroptiontranslation.AnswerOptionTranslationID,
                AnswerOptionID = answeroptiontranslation.AnswerOptionID,
                 AnswerOptionText = answeroptiontranslation.AnswerOptionText,
                 LanguageID = answeroptiontranslation.LanguageID
             
            };
        }
    }
}
