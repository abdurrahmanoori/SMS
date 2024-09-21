using SMS.Entities;
namespace RepositoryContracts.DTOs
{
    public class SurveyResponseDetailResponseDto
    {
        public int SurveyResponseDetailID { get; set; }
        public int SurveyResponseID { get; set; }
        public int SurveyInstanceQuestionID { get; set; }
        public int? AnswerOptionID { get; set; }  // For multiple choice or single choice questions
        public string FreeTextAnswer { get; set; }  // For open-ended questions

    }

    public static class SurveyResponseDetailExtention
    {
        public static SurveyResponseDetailResponseDto ToSurveyResponseDetailResponseDto(this SurveyResponseDetail surveyresponsedetail)
        {
            return new SurveyResponseDetailResponseDto
            {
                AnswerOptionID = surveyresponsedetail.AnswerOptionID,
                FreeTextAnswer = surveyresponsedetail.FreeTextAnswer,
                SurveyInstanceQuestionID = surveyresponsedetail.SurveyInstanceQuestionID,
                SurveyResponseDetailID = surveyresponsedetail.SurveyResponseDetailID,
                SurveyResponseID = surveyresponsedetail.SurveyResponseID

            };
        }
    }
}
