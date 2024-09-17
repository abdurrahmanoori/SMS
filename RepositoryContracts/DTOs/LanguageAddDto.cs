using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class LanguageAddDto
    {
        public string? LanguageCode { get; set; }  // e.g., "en", "fa", "ur"
        public string LanguageName { get; set; }


        // public DateTime CreatedDate { get; set; }
        //public bool IsActive { get; set; }

        public Language ToLanguage()
        {
            return new Language
            {
                LanguageCode = LanguageCode,
                LanguageName= LanguageName
               // LanguageDescription = LanguageDescription,
                //CreatedDate = CreatedDate,
                //IsActive = IsActive
            };
        }

    }
}
