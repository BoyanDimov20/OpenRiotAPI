using Microsoft.AspNetCore.Mvc;
using OpenRiotAPI;

namespace AspNetCoreMVC.Controllers
{
    public class SummonerController : Controller
    {
        private readonly RiotClient riotClient;

        public SummonerController(RiotClient riotClient)
        {
            this.riotClient = riotClient;
        }

        public async Task<IActionResult> Get()
        {
            var response = await this.riotClient.Summoners.GetSummonerByName("Sorion99", OpenRiotAPI.Common.Region.EUNE);

            return Json(response.Result);
        }
    }
}
