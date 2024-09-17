using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities
{


    public class SurveyResponseDetail
    {
        public int SurveyResponseDetailID { get; set; }
        public int SurveyResponseID { get; set; }
        public int SurveyInstanceQuestionID { get; set; }
        public int? AnswerOptionID { get; set; }  // For multiple choice or single choice questions
        public string FreeTextAnswer { get; set; }  // For open-ended questions

        public SurveyResponse SurveyResponse { get; set; }
        public SurveyInstanceQuestion SurveyInstanceQuestion { get; set; }
        public AnswerOption AnswerOption { get; set; }

    }
}
