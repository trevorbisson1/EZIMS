using EZIMS.MODELS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EZIMS.API.Controllers
{
    [ApiController]
    public class ItemController : Controller
    {
        private EZIMSApiDBContext _context;

        public ItemController(EZIMSApiDBContext context) { 
            _context = context;
        }

        [HttpGet("GetItem")]

        public async Task<IActionResult> GetItem(int itemID)
        {
            try
            {
                return Ok();
            }
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
