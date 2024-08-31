namespace Entities
{
    public class Test
    {
        public int TestId { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? Duration { get; set; }
        
    }
}
