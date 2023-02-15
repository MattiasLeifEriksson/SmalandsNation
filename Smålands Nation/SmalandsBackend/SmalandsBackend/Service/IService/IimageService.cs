using SmalandsBackend.Models;
using SmalandsBackend.Models.DTOs;

namespace SmalandsBackend.Service.IService
{
    public interface IimageService
    {

        public Task<IEnumerable<image>> GetAllImages();
        public Task<ReadImageDTO> CreateImage(CreateImageDTO imageDTO);
        public Task<image> GetImageById(int imageId);
    }
}
