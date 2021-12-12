using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SummonerEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.SummonerEndpoint
{
    internal interface ISummonerEndpoint
    {
        SummonerDto GetSummonerByAccountId(string accountId, Region region);

        SummonerDto GetSummonerByName(string summonerName, Region region);

        SummonerDto GetSummonerByPuuid(string puuid, Region region);

        SummonerDto GetSummonerById(string summonerId, Region region);

        SummonerDto GetMySummoner(Region region);
    }
}
