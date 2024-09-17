using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseResponseDto
    {
        public int SurveyResponseID { get; set; }
        public string SurveyResponseDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyResponseExtention
    {
        public static SurveyResponseResponseDto ToSurveyResponseResponseDto(this SurveyResponse surveyesponse)
        {
            return new SurveyResponseResponseDto
            {
                SurveyResponseID = surveyesponse.SurveyResponseID,
                SurveyResponseDescription = surveyesponse.SurveyResponseDescription,
                CreatedDate = surveyesponse.CreatedDate,
                IsActive = surveyesponse.IsActive,
            };
        }
    }
}
