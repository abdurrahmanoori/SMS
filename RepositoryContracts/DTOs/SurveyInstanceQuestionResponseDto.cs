using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceQuestionResponseDto
    {
        public int SurveyInstanceQuestionID { get; set; }
        public string SurveyInstanceQuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyInstanceQuestionExtention
    {
        public static SurveyInstanceQuestionResponseDto ToSurveyInstanceQuestionResponseDto(this SurveyInstanceQuestion surveyinstancequestion)
        {
            return new SurveyInstanceQuestionResponseDto
            {
                SurveyInstanceQuestionID = surveyinstancequestion.SurveyInstanceQuestionID,
                SurveyInstanceQuestionDescription = surveyinstancequestion.SurveyInstanceQuestionDescription,
                CreatedDate = surveyinstancequestion.CreatedDate,
                IsActive = surveyinstancequestion.IsActive
            };
        }
    }
}
