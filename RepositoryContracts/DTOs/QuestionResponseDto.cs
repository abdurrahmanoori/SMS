using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class QuestionResponseDto
    {
        public int QuestionID { get; set; }
        public int SurveyID { get; set; }
        public string QuestionType { get; set; }
        public bool IsRequired { get; set; }
    }

    public static class QuestionExtention
    {
        public static QuestionResponseDto ToQuestionResponseDto(this Question question)
        {
            return new QuestionResponseDto
            {
                QuestionID = question.QuestionID,
                IsRequired = question.IsRequired,
                SurveyID = question.SurveyID,
                QuestionType = question.QuestionType,                
            };
        }
    } 
}
