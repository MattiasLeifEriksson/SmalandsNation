namespace SmalandsBackend.Models.DTOs
{
    public class UpdateBoardDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? PictureUrl { get; set; }

    }
}
