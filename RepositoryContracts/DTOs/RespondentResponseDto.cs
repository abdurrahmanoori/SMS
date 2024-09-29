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
        public string Name { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }  // Example: "Kabul", "Tehran", etc.

    }

    public static class RespondentExtention
    {
        public static RespondentResponseDto ToRespondentResponseDto(this Respondent respondent)
        {
            return new RespondentResponseDto
            {
              Email = respondent.Email,
              //Name = respondent.Name,
              Province = respondent.Province,
              RespondentID = respondent.RespondentID

            };
        }
    }
}
