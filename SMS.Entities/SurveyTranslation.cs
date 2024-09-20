namespace SMS.Entities
{

    public class SurveyTranslation
    {
        public int SurveyTranslationID { get; set; }
        public int SurveyID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string Title { get; set; }
        public string Description { get; set; }

        public Survey Survey { get; set; }
        public Language Language { get; set; }

    }
}
