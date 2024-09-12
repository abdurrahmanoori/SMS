using SMS.Entities;

namespace RepositoryContracts.DTOs
{
    public class LanguageResponseDto
    {
        public int LanguageID { get; set; }
        public string LanguageDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }


    public static class LanguageExtention
    {
        public static LanguageResponseDto ToLanguageResponseDto(this Language language)
        {
            return new LanguageResponseDto
            {
                LanguageID = language.LanguageID,
                LanguageDescription = language.LanguageDescription,
                CreatedDate = language.CreatedDate,
                IsActive = language.IsActive,
            };
        }
    }
}
