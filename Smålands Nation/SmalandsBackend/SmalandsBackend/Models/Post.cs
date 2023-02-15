namespace SmalandsBackend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Content { get; set; }
        public string? author { get; set; } = "Smålands Nation";


    }
}
