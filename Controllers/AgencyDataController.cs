using Microsoft.AspNetCore.Mvc;
using CannabisAPI.Models;
using CannabisAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CannabisApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyDataController : ControllerBase
    {
        private readonly DataContext _context;

        public AgencyDataController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AgencyData agencyData)
        {
            if (agencyData == null)
            {
                return BadRequest("AgencyData is null");
            }

            try
            {
                _context.Agencies.Add(agencyData);
                _context.SaveChanges();

                return CreatedAtAction(nameof(Get), new { id = agencyData.Agency_ID }, agencyData);
                // 'Get' should be a separate action that returns the data for a single agency, given its ID.
            }
            catch (Exception ex)
            {
                // log the exception (if logging is configured)
                return StatusCode(500, "An error occurred while saving the agency data. Please try again later.");
            }
        }

        // Example HTTP GET method to get AgencyData by ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var agencyData = _context.Agencies.Find(id);

            if (agencyData == null)
            {
                return NotFound();
            }

            return Ok(agencyData);
        }
    }
}