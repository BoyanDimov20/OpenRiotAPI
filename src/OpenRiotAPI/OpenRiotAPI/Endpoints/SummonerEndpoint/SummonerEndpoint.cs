using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.SummonerEndpoint.Dtos;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.SummonerEndpoint
{
    internal class SummonerEndpoint : EndpointBase, ISummonerEndpoint
    {
        private const string MySummonerUrl = "lol/summoner/v4/summoners/me";
        private const string SummonerByAccountId = "lol/summoner/v4/summoners/by-account";
        private const string SummonerBySummonerId = "lol/summoner/v4/summoners";
        private const string SummonerByPuuid = "lol/summoner/v4/summoners/by-puuid";

        public SummonerEndpoint(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task<RiotResponse<SummonerDto>> GetMySummoner(Region region, string accessToken = null)
        {
            if (accessToken != null)
            {
                using HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", accessToken);

                var endpoint = new SummonerEndpoint(httpClient);
                return endpoint.GetMySummoner(region);
            }

            var url = $"{RiotUri.CreateUrl(region, MySummonerUrl)}";

            return this.httpRequester.GetAsync<SummonerDto>(url);
        }

        public Task<RiotResponse<SummonerDto>> GetSummonerByAccountId(string accountId, Region region)
        {
            var url = $"{RiotUri.CreateUrl(region, SummonerByAccountId)}/{accountId}";

            return this.httpRequester.GetAsync<SummonerDto>(url);
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
