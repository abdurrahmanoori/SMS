using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities
{

    public class QuestionTranslation
    {
        public int QuestionTranslationID { get; set; }
        public int QuestionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string QuestionText { get; set; }

        public Question Question { get; set; }
        public Language Language { get; set; }
    }
}
