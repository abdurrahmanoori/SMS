using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class RespondentAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DateOfBirth { get; set; }
        public string Province { get; set; }
        public string EducationLevel { get; set; }


        public Respondent ToRespondent()
        {
            return new Respondent
            {
                FirstName = FirstName,
                LastName = LastName,
                Gender=Gender,
                Email = Email,
                PhoneNumber = PhoneNumber,
                DateOfBirth = DateOfBirth,
                Province = Province,
                EducationLevel = EducationLevel

            };
        }
    }
}
