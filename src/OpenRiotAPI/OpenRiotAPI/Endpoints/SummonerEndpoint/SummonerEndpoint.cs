using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SummonerEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.SummonerEndpoint
{
    internal class SummonerEndpoint : ISummonerEndpoint
    {
        private readonly string apiKey;
        private const string MySummonerUrl = "/lol/summoner/v4/summoners/me";

        public SummonerEndpoint(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public SummonerDto GetMySummoner(Region region)
        {

        }

        public SummonerDto GetSummonerByAccountId(string accountId, Region region)
        {
            throw new NotImplementedException();
        }

        public SummonerDto GetSummonerById(string summonerId, Region region)
        {
            throw new NotImplementedException();
        }

        public SummonerDto GetSummonerByName(string summonerName, Region region)
        {
            throw new NotImplementedException();
        }

        public SummonerDto GetSummonerByPuuid(string puuid, Region region)
        {
            throw new NotImplementedException();
        }
    }
}
