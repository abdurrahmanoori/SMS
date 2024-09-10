namespace SMS.Entities
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public string SurveyDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
