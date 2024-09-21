namespace SMS.Entities
{

    public class SurveyResponse
    {
        public int SurveyResponseID { get; set; }
        public int SurveyInstanceID { get; set; }
        public int RespondentID { get; set; }
        public DateTime ResponseDate { get; set; }

        public SurveyInstance SurveyInstance { get; set; }
        public Respondent Respondent { get; set; }
        public ICollection<SurveyResponseDetail> SurveyResponseDetails { get; set; }

    }
}
