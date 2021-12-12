using OpenRiotAPI.Endpoints.AccountEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.AccountEndpoint
{
    internal interface IAccountEndpoint
    {
        AccountDto GetAccountByPuuid(string puuid);

        AccountDto GetAccountByRiotId(string tagLine, string gameName);

        AccountDto GetActiveShards(string game, string puuid);

        AccountDto GetMyAccount();
    }
}
