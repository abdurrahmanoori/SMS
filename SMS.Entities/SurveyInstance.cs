namespace SMS.Entities
{
    public class SurveyInstance
    {
        public int SurveyInstanceID { get; set; }
        public int SurveyID { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public bool IsActive { get; set; }

        public Survey Survey { get; set; }
        public ICollection<SurveyInstanceQuestion> SurveyInstanceQuestions { get; set; }
        public ICollection<SurveyResponse> SurveyResponses { get; set; }
    }
}
