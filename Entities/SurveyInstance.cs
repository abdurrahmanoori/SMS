namespace Entities
{
    public class SurveyInstance
    {
        public int SurveyInstanceID { get; set; }
        public int SurveyID { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime DeactivationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
