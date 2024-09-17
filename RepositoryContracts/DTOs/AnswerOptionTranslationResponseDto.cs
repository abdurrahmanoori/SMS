using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionTranslationResponseDto
    {
        public int AnswerOptionTranslationID { get; set; }
        public string AnswerOptionTranslationDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class AnswerOptionTranslationExtention
    {
        public static AnswerOptionTranslationResponseDto ToAnswerOptionTranslationResponseDto(this AnswerOptionTranslation answeroptiontranslation)
        {
            return new AnswerOptionTranslationResponseDto
            {
                AnswerOptionTranslationID = answeroptiontranslation.AnswerOptionTranslationID,
                AnswerOptionTranslationDescription = answeroptiontranslation.AnswerOptionTranslationDescription,
                CreatedDate = answeroptiontranslation.CreatedDate,
                IsActive = answeroptiontranslation.IsActive
            };
        }
    }
}
