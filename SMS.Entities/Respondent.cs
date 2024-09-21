namespace SMS.Entities
{

    public class Respondent
    {
        public int RespondentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }  // Example: "Kabul", "Tehran", etc.

        public ICollection<SurveyResponse> SurveyResponses { get; set; }
    }
}
