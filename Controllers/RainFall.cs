using Microsoft.AspNetCore.Mvc;

namespace Sorted_Coding_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainFall : ControllerBase
    {
        [HttpGet]
        public string RainFallReading(string stationId)
        {
            var returnObj = "";

            return returnObj;
        }
    }
}
