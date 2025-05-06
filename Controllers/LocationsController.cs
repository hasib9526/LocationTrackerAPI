using Microsoft.AspNetCore.Mvc;
using LocationTrackerAPI.Data;
using LocationTrackerAPI.Models;

namespace LocationTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LocationsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostLocation([FromBody] Location location)
        {
            location.Timestamp = DateTime.UtcNow;
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Location saved" });
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_context.Locations.OrderByDescending(x => x.Timestamp).ToList());
    }
}

