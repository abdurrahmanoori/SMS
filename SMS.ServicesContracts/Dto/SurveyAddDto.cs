using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.ServicesContracts.Dto
{
    public class SurveyAddDto
    {
       
        public string SurveyDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
       


        public Survey ToSurvey()
        {
            return new Survey
            {
                SurveyDescription = SurveyDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
           
        }

    }
}
