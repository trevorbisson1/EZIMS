using EZIMS.MODELS.Methods;
using EZIMS.MODELS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EZIMS.API.Controllers
{
    [ApiController]
    public class ItemController : Controller
    {
        private ItemMethods _itemMethods;

        public ItemController(ItemMethods itemMethods) {
            _itemMethods = itemMethods;
        }

        [HttpGet("GetItem")]

        public async Task<IActionResult> GetItem(int itemID)
        {
            try
            {
                var value = await _itemMethods.GetItemByIDAsync(itemID);
                return Ok(JsonConvert.SerializeObject(value));
            }
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
