namespace SMS.Entities
{

    public class Language
    {
        public int LanguageID { get; set; }     

        public string? LanguageCode { get; set; }  // e.g., "en", "fa", "ur"
        public string LanguageName { get; set; }
       // public bool IsActive { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public string LanguageDescription { get; set; }
     
    }
}
