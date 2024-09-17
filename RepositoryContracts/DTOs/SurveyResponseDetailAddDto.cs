using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseDetailAddDto
    {
        public string SurveyResponseDetailDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public SurveyResponseDetail ToSurveyResponseDetail()
        {
            return new SurveyResponseDetail
            {
                SurveyResponseDetailDescription = SurveyResponseDetailDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
