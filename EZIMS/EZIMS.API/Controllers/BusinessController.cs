using EZIMS.MODELS.Methods;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EZIMS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : Controller
    {
        private BusinessMethods _businessMethods;

        public BusinessController(BusinessMethods businessMethods)
        {
            _businessMethods = businessMethods;
        }
        [HttpGet("GetBusinessByID")]
        public async Task<IActionResult> GetBusinessByID(Guid businessID)
        {
            try
            {
                var business = await _businessMethods.GetBusinessAsync(businessID);
                return Ok(JsonConvert.SerializeObject(business));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
