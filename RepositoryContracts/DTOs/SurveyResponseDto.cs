using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseDto
    {
        public int SurveyID { get; set; }
        public string SurveyDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyExtention
    {
        public static SurveyResponseDto ToSurveResponseDto(this Survey survey)
        {
            return new SurveyResponseDto
            {
                SurveyID  =survey.SurveyID,
                SurveyDescription = survey.SurveyDescription,
                CreatedDate = survey.CreatedDate,
                IsActive = survey.IsActive
            };
        }
    }
}
