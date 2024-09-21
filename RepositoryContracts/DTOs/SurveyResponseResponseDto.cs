using SMS.Entities;
namespace RepositoryContracts.DTOs
{
    public class SurveyResponseResponseDto
    {
        public int SurveyResponseID { get; set; }
        public int SurveyInstanceID { get; set; }
        public int RespondentID { get; set; }
        public DateTime ResponseDate { get; set; }

    }

    public static class SurveyResponseExtention
    {
        public static SurveyResponseResponseDto ToSurveyResponseResponseDto(this SurveyResponse surveyesponse)
        {
            return new SurveyResponseResponseDto
            {
               SurveyInstanceID = surveyesponse.SurveyInstanceID,
               ResponseDate = surveyesponse.ResponseDate,
               RespondentID = surveyesponse.RespondentID,
               SurveyResponseID = surveyesponse.SurveyResponseID
            };
        }
    }
}
