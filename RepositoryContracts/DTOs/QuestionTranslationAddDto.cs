using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class QuestionTranslationAddDto
    {
        public string QuestionTranslationDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public QuestionTranslation ToQuestionTranslation()
        {
            return new QuestionTranslation
            {
                QuestionTranslationDescription = QuestionTranslationDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
