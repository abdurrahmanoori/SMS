using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class RespondentAddDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }  // Example: "Kabul", "Tehran", etc.


        public Respondent ToRespondent()
        {
            return new Respondent
            {
               Email = Email,
               //Name = Name,
               Province = Province,
            };
        }
    }
}
