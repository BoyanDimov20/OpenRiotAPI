using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SummonerEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.SummonerEndpoint
{
    public interface ISummonerEndpoint
    {
        Task<RiotResponse<SummonerDto>> GetSummonerByAccountId(string accountId, Region region);
        Task<RiotResponse<SummonerDto>> GetSummonerByName(string summonerName, Region region);
        Task<RiotResponse<SummonerDto>> GetSummonerByPuuid(string puuid, Region region);
        Task<RiotResponse<SummonerDto>> GetSummonerById(string summonerId, Region region);
        Task<RiotResponse<SummonerDto>> GetMySummoner(Region region, string accessToken = null);
    }
}
