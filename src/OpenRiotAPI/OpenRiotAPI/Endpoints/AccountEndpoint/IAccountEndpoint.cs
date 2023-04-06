using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.AccountEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.AccountEndpoint
{
    internal interface IAccountEndpoint
    {
        Task<RiotResponse<AccountDto>> GetAccountByPuuid(string puuid, LongRegion region);

        Task<RiotResponse<AccountDto>> GetAccountByRiotId(string tagLine, string gameName, LongRegion region);

        Task<RiotResponse<AccountDto>> GetActiveShards(string game, string puuid, LongRegion region);

        Task<RiotResponse<AccountDto>> GetMyAccount(string authorization, LongRegion region);
    }
}
