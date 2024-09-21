using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class LanguageResponseDto
    {
        public int LanguageID { get; set; }

        public string? LanguageCode { get; set; }  // e.g., "en", "fa", "ur"
        public string LanguageName { get; set; }


    }


    public static class LanguageExtention
    {
        public static LanguageResponseDto ToLanguageResponseDto(this Language language)
        {
            return new LanguageResponseDto
            {
                LanguageID = language.LanguageID,
                
                LanguageName = language.LanguageName,
                LanguageCode = language.LanguageCode
                
            };
        }
    }
}
