using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceResponseDto
    {
        public int SurveyInstanceID { get; set; }
        public string SurveyInstanceDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyInstanceExtention
    {
        public static SurveyInstanceResponseDto ToSurveyInstanceResponseDto(this SurveyInstance surveyinstance)
        {
            return new SurveyInstanceResponseDto
            {
                SurveyInstanceID = surveyinstance.SurveyInstanceID,
                SurveyInstanceDescription = surveyinstance.SurveyInstanceDescription,
                CreatedDate = surveyinstance.CreatedDate,
                IsActive = surveyinstance.IsActive
            };
        }
    }
}
