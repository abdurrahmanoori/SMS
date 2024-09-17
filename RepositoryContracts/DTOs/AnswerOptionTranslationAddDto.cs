using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionTranslationAddDto
    {
        public string AnswerOptionTranslationDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public AnswerOptionTranslation ToAnswerOptionTranslation()
        {
            return new AnswerOptionTranslation
            {
                AnswerOptionTranslationDescription = AnswerOptionTranslationDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
