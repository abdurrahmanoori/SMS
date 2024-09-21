using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class SurveyResponseAddDto
    {
        public int SurveyInstanceID { get; set; }
        public int RespondentID { get; set; }
        public DateTime ResponseDate { get; set; }

        public SurveyResponse ToSurveyResponse()
        {
            return new SurveyResponse
            {
               RespondentID = RespondentID,
               ResponseDate = ResponseDate,
               SurveyInstanceID = SurveyInstanceID
            };
        }
    }
}
