using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionAddDto
    {
        public int QuestionID { get; set; }

        public AnswerOption ToAnswerOption()
        {
            return new AnswerOption
            {
                QuestionID = QuestionID
            };
        }
    }
}
