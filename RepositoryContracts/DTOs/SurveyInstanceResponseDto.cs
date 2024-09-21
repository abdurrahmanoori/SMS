using SMS.Entities;
namespace RepositoryContracts.DTOs
{
    public class SurveyInstanceResponseDto
    {
        public int SurveyInstanceID { get; set; }
        public int SurveyID { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyInstanceExtention
    {
        public static SurveyInstanceResponseDto ToSurveyInstanceResponseDto(this SurveyInstance surveyinstance)
        {
            return new SurveyInstanceResponseDto
            {
               DeactivationDate = surveyinstance.ActivationDate,
               SurveyID = surveyinstance.SurveyID,
               ActivationDate = surveyinstance.ActivationDate,
               IsActive = surveyinstance.IsActive

            };
        }
    }
}
