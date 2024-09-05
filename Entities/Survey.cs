namespace Entities
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SurveyTranslation> Translations { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<SurveyInstance> SurveyInstances { get; set; }

    }
}
