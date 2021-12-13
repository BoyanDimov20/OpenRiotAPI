using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SummonerEndpoint.Dtos;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.SummonerEndpoint
{
    internal class SummonerEndpoint : ISummonerEndpoint
    {
        private readonly HttpRequester httpRequester;

        private const string MySummonerUrl = "lol/summoner/v4/summoners/me";
        private const string SummonerByAccountId = "lol/summoner/v4/summoners/by-account";
        private const string SummonerBySummonerId = "lol/summoner/v4/summoners";
        private const string SummonerByPuuid = "lol/summoner/v4/summoners/by-puuid";

        public SummonerEndpoint(HttpClient httpClient)
        {
            this.httpRequester = new HttpRequester(httpClient);
        }

        public async Task<RiotResponse<SummonerDto>> GetMySummoner(Region region)
        {
            throw new NotImplementedException();
        }

        public async Task<RiotResponse<SummonerDto>> GetSummonerByAccountId(string accountId, Region region)
        {
            var url = $"{RiotUri.CreateUrl(region, SummonerByAccountId)}/{accountId}";

            return await this.httpRequester.GetAsync<SummonerDto>(url);
        }

        public Task<RiotResponse<SummonerDto>> GetSummonerById(string summonerId, Region region)
        {
            var url = $"{RiotUri.CreateUrl(region, SummonerBySummonerId)}/{summonerId}";

            return this.httpRequester.GetAsync<SummonerDto>(url);
        }

        public Task<RiotResponse<SummonerDto>> GetSummonerByName(string summonerName, Region region)
        {
            var url = $"{RiotUri.CreateUrl(region, GlobalConstants.SummonerByNameUrl)}/{summonerName}";

            return this.httpRequester.GetAsync<SummonerDto>(url);
        }

        public Task<RiotResponse<SummonerDto>> GetSummonerByPuuid(string puuid, Region region)
        {
            var url = $"{RiotUri.CreateUrl(region, SummonerByPuuid)}/{puuid}";

            return this.httpRequester.GetAsync<SummonerDto>(url);
        }
    }
}
