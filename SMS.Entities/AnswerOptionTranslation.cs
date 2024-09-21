namespace SMS.Entities
{
    public class AnswerOptionTranslation
    {
        public int AnswerOptionTranslationID { get; set; }
        public int AnswerOptionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        //This about this.
        public string AnswerOptionText { get; set; }
        public AnswerOption AnswerOption { get; set; }
        public Language Language { get; set; }

    }
}
