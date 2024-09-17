using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities
{
    public class AnswerOptionTranslation
    {
        public int AnswerOptionTranslationID { get; set; }
        public int AnswerOptionID { get; set; }
        public int LanguageID { get; set; }  // Foreign key to Language
        public string OptionText { get; set; }

        public AnswerOption AnswerOption { get; set; }
        public Language Language { get; set; }
        public string AnswerOptionTranslationDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
