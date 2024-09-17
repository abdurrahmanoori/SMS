using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.DTOs
{
    public class QuestionResponseDto
    {
        public int QuestionID { get; set; }
        public string QuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }

    public static class QuestionExtention
    {
        public static QuestionResponseDto ToQuestionResponseDto(this Question question)
        {
            return new QuestionResponseDto
            {
                QuestionID = question.QuestionID,
                QuestionDescription = question.QuestionDescription,
                CreatedDate = question.CreatedDate,
                IsActive = question.IsActive
            };
        }
    } 
}
