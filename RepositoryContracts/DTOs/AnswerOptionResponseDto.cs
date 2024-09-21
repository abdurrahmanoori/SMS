using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionResponseDto
    {
        public int AnswerOptionID { get; set; }
        public int QuestionID { get; set; }
    }

    public static class Extention
    {
        public static AnswerOptionResponseDto ToAnswerOptionResponseDto(this AnswerOption answeroption)
        {
            return new AnswerOptionResponseDto
            {
                AnswerOptionID = answeroption.AnswerOptionID,
                QuestionID = answeroption.AnswerOptionID
            };
        }
    }
}
