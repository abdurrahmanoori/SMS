using SMS.Entities; 

namespace RepositoryContracts.DTOs
{
    public class QuestionAddDto
    {
        public int SurveyID { get; set; }
        public string QuestionType { get; set; }
        public bool IsRequired { get; set; }
        public Question ToQuestion()
        {
            return new Question
            {
              IsRequired= IsRequired,
              SurveyID= SurveyID,
              QuestionType= QuestionType,
            };
        }
    }
}
