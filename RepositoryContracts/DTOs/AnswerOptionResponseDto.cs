using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class AnswerOptionResponseDto
    {
        public int AnswerOptionID { get; set; }
        public string AnswerOptionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class Extention
    {
        public static AnswerOptionResponseDto ToAnswerOptionResponseDto(this AnswerOption answeroption)
        {
            return new AnswerOptionResponseDto
            {
                AnswerOptionID = answeroption.AnswerOptionID,
                AnswerOptionDescription = answeroption.AnswerOptionDescription,
                CreatedDate = answeroption.CreatedDate,
                IsActive = answeroption.IsActive,
            };
        }
    }
}
