using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.SpectatorEndpoint
{
    public interface ISpectatorEndpoint
    {
        public Task<RiotResponse<CurrentGame>> GetActiveGameBySummonerName(string summonerName, Region region);

        public Task<RiotResponse<FeaturedGames>> GetFeaturedGames(Region region);

        public Task<RiotResponse<CurrentGame>> GetActiveGameBySummonerId(string summonerId, Region region);

    }
}
