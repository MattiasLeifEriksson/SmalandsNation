//using SmalandsBackend.DataAccess;
using SmalandsBackend.DataAccess;
using SmalandsBackend.Models;
//using SmalandsBackend.Interfaces;
//using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SmalandsBackend.Service.IService;
using SmalandsBackend.Models.DTOs;
using AutoMapper;

namespace SmalandsBackend.Services
{
    public class ImageService : IimageService
    {
        private readonly SmalandsDbContext _context;
        private readonly IMapper _mapper;

        public ImageService(SmalandsDbContext context, IMapper mapper)
        {
            _context = context;
           _mapper = mapper;

        }
        /// <summary>
        /// Get all Board members
        /// </summary>
        /// <returns>A list of all members</returns>
        public async Task<IEnumerable<image>> GetAllImages()
        {
            return await _context.images.ToListAsync();

        }

  
        public async Task<image> GetImageById(int imageId)
        {
            var image = await _context.images.FirstOrDefaultAsync(g => g.Id == imageId);




            return image;
        }

        public async Task<ReadImageDTO> CreateImage(CreateImageDTO imageDTO)
        {
            image newImage = _mapper.Map<image>(imageDTO);

            await _context.images.AddAsync(newImage);

            if (_context.SaveChanges() == 0)
                throw new Exception("Image not added to DB");

            return _mapper.Map<ReadImageDTO>(newImage);


        }
    }
}