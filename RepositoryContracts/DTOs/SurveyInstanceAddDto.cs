using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceAddDto
    {
        public int SurveyID { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public bool IsActive { get; set; }

        public SurveyInstance ToSurveyInstance()
        {
            return new SurveyInstance
            {
                SurveyID= SurveyID,
                ActivationDate= ActivationDate,
                IsActive = IsActive,
                DeactivationDate=DeactivationDate 
            };
        }
    }
}
