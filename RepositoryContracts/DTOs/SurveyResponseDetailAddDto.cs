using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseDetailAddDto
    {
        public int SurveyResponseID { get; set; }
        public int SurveyInstanceQuestionID { get; set; }
        public int? AnswerOptionID { get; set; }  // For multiple choice or single choice questions
        public string FreeTextAnswer { get; set; }  // For open-ended questions

        public SurveyResponseDetail ToSurveyResponseDetail()
        {
            return new SurveyResponseDetail
            {
             SurveyResponseID = SurveyResponseID,
             AnswerOptionID = AnswerOptionID,
             FreeTextAnswer = FreeTextAnswer,
             SurveyInstanceQuestionID = SurveyInstanceQuestionID,
            };
        }
    }
}
