using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos;
using OpenRiotAPI.Endpoints.SummonerEndpoint.Dtos;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.SpectatorEndpoint
{
    public class SpectatorEndpoint : EndpointBase, ISpectatorEndpoint
    {
        private const string ActiveGameBySummonerUrl = "lol/spectator/v4/active-games/by-summoner/{0}";
        private const string FeaturedGamesUrl = "lol/spectator/v4/featured-games";
        private const string SummonerByName = "lol/summoner/v4/summoners/by-name/{0}";

        public SpectatorEndpoint(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<RiotResponse<CurrentGame>> GetActiveGameBySummonerName(string summonerName, Region region)
        {
            var summoner = await this.httpRequester.GetAsync<SummonerDto>(RiotUri.CreateUrl(region, SummonerByName, summonerName));
            if (!summoner.IsSucessful)
            {
                return new RiotResponse<CurrentGame>
                {
                    ErrorMessage = summoner.ErrorMessage
                };
            }
            return await this.httpRequester.GetAsync<CurrentGame>(RiotUri.CreateUrl(region, ActiveGameBySummonerUrl, summoner.Result.Id));
        }

        public Task<RiotResponse<CurrentGame>> GetActiveGameBySummonerId(string summonerId, Region region)
        {
            return this.httpRequester.GetAsync<CurrentGame>(RiotUri.CreateUrl(region, ActiveGameBySummonerUrl, summonerId));
        }

        public Task<RiotResponse<FeaturedGames>> GetFeaturedGames(Region region)
        {
            return this.httpRequester.GetAsync<FeaturedGames>(RiotUri.CreateUrl(region, FeaturedGamesUrl));
        }
    }
}
