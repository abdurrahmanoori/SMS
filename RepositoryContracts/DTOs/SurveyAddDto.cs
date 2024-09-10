using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyAddDto
    {
        public string SurveyDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public Survey ToSurvey()
        {
            return new Survey
            {
                SurveyDescription = SurveyDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }

    }

}
