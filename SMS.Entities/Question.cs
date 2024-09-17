namespace SMS.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int SurveyID { get; set; }
        public string QuestionType { get; set; }
        public bool IsRequired { get; set; }

        public Survey Survey { get; set; }
        public ICollection<QuestionTranslation> Translations { get; set; }
        public ICollection<SurveyInstanceQuestion> SurveyInstanceQuestions { get; set; }
        public ICollection<AnswerOption> AnswerOptions { get; set; }
        public string QuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
