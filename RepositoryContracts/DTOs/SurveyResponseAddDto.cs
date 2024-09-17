using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseAddDto
    {
        public string SurveyResponseDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public SurveyResponse ToSurveyResponse()
        {
            return new SurveyResponse
            {
                SurveyResponseDescription = SurveyResponseDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
