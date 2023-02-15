using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmalandsBackend.DataAccess;
using SmalandsBackend.Models;

namespace SmalandsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class imagesController : ControllerBase
    {
        private readonly SmalandsDbContext _context;

        public imagesController(SmalandsDbContext context)
        {
            _context = context;
        }

        // GET: api/images
        [HttpGet]
        public async Task<ActionResult<IEnumerable<image>>> Getimages()
        {
            return await _context.images.ToListAsync();
        }

        // GET: api/images/5
        [HttpGet("{id}")]
        public async Task<ActionResult<image>> Getimage(int id)
        {
            var image = await _context.images.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return image;
        }

        // PUT: api/images/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putimage(int id, image image)
        {
            if (id != image.Id)
            {
                return BadRequest();
            }

            _context.Entry(image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!imageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/images
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<image>> Postimage(image image)
        {
            _context.images.Add(image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getimage", new { id = image.Id }, image);
        }

        // DELETE: api/images/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteimage(int id)
        {
            var image = await _context.images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }

            _context.images.Remove(image);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool imageExists(int id)
        {
            return _context.images.Any(e => e.Id == id);
        }
    }
}
