using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class RespondentResponseDto
    {
        public int RespondentID { get; set; }
        public string RespondentDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class RespondentExtention
    {
        public static RespondentResponseDto ToRespondentResponseDto(this Respondent respondent)
        {
            return new RespondentResponseDto
            {
                RespondentID = respondent.RespondentID,
                RespondentDescription = respondent.RespondentDescription,
                CreatedDate = respondent.CreatedDate,
                IsActive = respondent.IsActive
            };
        }
    }
}
