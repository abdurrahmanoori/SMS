using SMS.Entities; 

namespace RepositoryContracts.DTOs
{
    public class QuestionAddDto
    {
        public string QuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public Question ToQuestion()
        {
            return new Question
            {
                QuestionDescription = QuestionDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
