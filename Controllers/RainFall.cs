using Microsoft.AspNetCore.Mvc;

namespace Sorted_Coding_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainFall : ControllerBase
    {
        private HttpClient client;
        public RainFall()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://environment.data.gov.uk/flood-monitoring/");
        }

        [HttpGet]
        public async Task<string> RainFallReading(string stationId)
        {
            try
            {
                var returnObj = "";

                HttpResponseMessage response = await client.GetAsync(
                    $"id/stations/{stationId}/readings");
                
                if (response.IsSuccessStatusCode)
                {
                    returnObj = await response.Content.ReadAsStringAsync();
                }
                return returnObj;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
