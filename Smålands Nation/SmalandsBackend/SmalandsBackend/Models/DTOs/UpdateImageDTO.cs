namespace SmalandsBackend.Models.DTOs
{
    public class UpdateImageDTO
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Description { get; set; }
        public string? PictureUrl { get; set; }
    }
}
