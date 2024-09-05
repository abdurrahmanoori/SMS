using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities
{
    public class AnswerOption
    {
        public int AnswerOptionID { get; set; }
        public int QuestionID { get; set; }
        public ICollection<AnswerOptionTranslation> Translations { get; set; }

        public Question Question { get; set; }
    }

}
