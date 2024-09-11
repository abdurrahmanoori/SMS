using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.ServicesContracts.Dto
{
    public class SurveyResponseDto
    {
        public int SurveyID { get; set; }
        public string SurveyDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class SurveyExtention
    {
        public static SurveyResponseDto ToSurveyResponseDto(this Survey Survey)
        {
            return new SurveyResponseDto
            {
                SurveyID = Survey.SurveyID,
                SurveyDescription = Survey.SurveyDescription,
                CreatedDate =Survey.CreatedDate,
                IsActive = Survey.IsActive
            };

        }
    }
}
