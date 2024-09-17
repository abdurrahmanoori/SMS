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
        public string QuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class QuestionTranslationExtention
    {
        public static QuestionTranslationResponseDto ToQuestionTranslationResponseDto(this QuestionTranslation questiontranslation)
        {
            return new QuestionTranslationResponseDto
            {
                QuestionTranslationID = questiontranslation.QuestionTranslationID,
                QuestionDescription = questiontranslation.QuestionTranslationDescription,
                CreatedDate = questiontranslation.CreatedDate,
                IsActive = questiontranslation.IsActive
            };
        }
    }
}
