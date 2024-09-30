using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class RespondentResponseDto
    {
        public int RespondentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DateOfBirth { get; set; }
        public string Province { get; set; }
        public string EducationLevel { get; set; }

    }

    public static class RespondentExtention
    {
        public static RespondentResponseDto ToRespondentResponseDto(this Respondent respondent)
        {
            return new RespondentResponseDto
            {
                RespondentId = respondent.RespondentID,
                FirstName = respondent.FirstName,
                LastName = respondent.LastName,
                Gender = respondent.Gender,
                Email = respondent.Email,
                PhoneNumber = respondent.PhoneNumber,
                DateOfBirth = respondent.DateOfBirth,
                Province = respondent.Province,
                EducationLevel = respondent.EducationLevel

            };
        }
    }
}
