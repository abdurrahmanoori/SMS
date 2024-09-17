using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionAddDto
    {
        public string AnswerOptionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public AnswerOption ToAnswerOption()
        {
            return new AnswerOption
            {
                AnswerOptionDescription = AnswerOptionDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
