using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
