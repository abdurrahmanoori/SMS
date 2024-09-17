using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class RespondentAddDto
    {
        public string RespondentDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public Respondent ToRespondent()
        {
            return new Respondent
            {
                RespondentDescription = RespondentDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive,
            };
        }
    }
}
