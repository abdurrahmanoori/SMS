namespace SMS.Entities
{

    public class SurveyInstanceQuestion
    {
        public int SurveyInstanceQuestionID { get; set; }
        public int SurveyInstanceID { get; set; }
        public int QuestionID { get; set; }

        public SurveyInstance SurveyInstance { get; set; }
        public Question Question { get; set; }

    }
}
