using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.AccountEndpoint.Dtos;
using OpenRiotAPI.Tools;
using System;
using System.Diagnostics;

namespace OpenRiotAPI.Endpoints.AccountEndpoint
{
    internal class AccountEndpoint : EndpointBase, IAccountEndpoint
    {
        private const string MyAccountUrl = "riot/account/v1/accounts/me";
        private const string AccountByPuuidUrl = "riot/account/v1/accounts/by-puuid/{0}";
        private const string AccountByRiotId = "riot/account/v1/accounts/by-riot-id/{0}/{1}";
        private const string ActiveShardsByGame = "riot/account/v1/active-shards/by-game/{0}/by-puuid/{1}";

        private readonly string apiKey;

        public AccountEndpoint(HttpClient httpClient): base(httpClient)
        {
        }

        public Task<RiotResponse<AccountDto>> GetAccountByPuuid(string puuid, LongRegion region)
        {
            var url = RiotUri.CreateUrl(region, AccountByPuuidUrl, puuid);
            return this.httpRequester.GetAsync<AccountDto>(url);
        }

        public Task<RiotResponse<AccountDto>> GetAccountByRiotId(string gameName, string tagLine, LongRegion region)
        {
            var url = RiotUri.CreateUrl(region, AccountByRiotId, gameName, tagLine);
            return this.httpRequester.GetAsync<AccountDto>(url);
        }

        public Task<RiotResponse<AccountDto>> GetActiveShards(string game, string puuid, LongRegion region)
        {
            var url = RiotUri.CreateUrl(region, AccountByRiotId, game, puuid);
            return this.httpRequester.GetAsync<AccountDto>(url);
        }

        public Task<RiotResponse<AccountDto>> GetMyAccount(string authorization, LongRegion region)
        {
            var url = RiotUri.CreateUrl(region, MyAccountUrl);
            return this.httpRequester.GetAsync<AccountDto>(url, authorization);
        }
    }
}
