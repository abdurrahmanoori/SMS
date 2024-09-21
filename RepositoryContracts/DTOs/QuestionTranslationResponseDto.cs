using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class QuestionTranslationResponseDto
    {
        public int QuestionTranslationID { get; set; }
        public int QuestionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string QuestionText { get; set; }
    }

    public static class QuestionTranslationExtention
    {
        public static QuestionTranslationResponseDto ToQuestionTranslationResponseDto(this QuestionTranslation questiontranslation)
        {
            return new QuestionTranslationResponseDto
            {
             LanguageID= questiontranslation.LanguageID,
             QuestionText= questiontranslation.QuestionText,
             QuestionID= questiontranslation.QuestionID,
             QuestionTranslationID= questiontranslation.QuestionTranslationID

            };
        }
    }
}
