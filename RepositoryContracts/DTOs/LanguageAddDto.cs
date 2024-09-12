using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class LanguageAddDto
    {
        public string LanguageDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public Language ToLanguage()
        {
            return new Language
            {
                LanguageDescription = LanguageDescription,
                CreatedDate = CreatedDate,
                IsActive = IsActive
            };
        }

    }
}
