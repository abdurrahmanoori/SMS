using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceAddDto
    {
        public string SurveyInstanceDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public SurveyInstance ToSurveyInstance()
        {
            return new SurveyInstance
            {
                SurveyInstanceDescription = SurveyInstanceDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }
    }
}
