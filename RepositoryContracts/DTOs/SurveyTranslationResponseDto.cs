using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class SurveyTranslationResponseDto
    {
        public int SurveyTranslationID { get; set; }
        public string SurveyTranslationDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyTranslationExtention
    {
        public static SurveyTranslationResponseDto ToSurveyTranslationResponseDto(this SurveyTranslation surveyranslation)
        {
            return new SurveyTranslationResponseDto
            {
                SurveyTranslationID = surveyranslation.SurveyTranslationID,
                SurveyTranslationDescription = surveyranslation.SurveyTranslationDescription,
                CreatedDate = surveyranslation.CreatedDate,
                IsActive = surveyranslation.IsActive,
            };
        }
    }
}
