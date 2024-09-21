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
        public int SurveyInstanceID { get; set; }
        public int QuestionID { get; set; }
    }

    public static class SurveyInstanceQuestionExtention
    {
        public static SurveyInstanceQuestionResponseDto ToSurveyInstanceQuestionResponseDto(this SurveyInstanceQuestion surveyinstancequestion)
        {
            return new SurveyInstanceQuestionResponseDto
            {
               QuestionID = surveyinstancequestion.QuestionID,
               SurveyInstanceID = surveyinstancequestion.SurveyInstanceID,
               SurveyInstanceQuestionID = surveyinstancequestion.SurveyInstanceQuestionID

            };
        }
    }
}
