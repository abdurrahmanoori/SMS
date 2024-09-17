using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseDetailResponseDto
    {
        public int SurveyResponseDetailID { get; set; }
        public string SurveyResponseDetailDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyResponseDetailExtention
    {
        public static SurveyResponseDetailResponseDto ToSurveyResponseDetailResponseDto(this SurveyResponseDetail surveyresponsedetail)
        {
            return new SurveyResponseDetailResponseDto
            {
                SurveyResponseDetailID = surveyresponsedetail.SurveyResponseDetailID,
                SurveyResponseDetailDescription = surveyresponsedetail.SurveyResponseDetailDescription,
                CreatedDate = surveyresponsedetail.CreatedDate,
                IsActive = surveyresponsedetail.IsActive,
            };
        }
    }
}
