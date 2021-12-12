using OpenRiotAPI.Endpoints.AccountEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.AccountEndpoint
{
    internal class AccountEndpoint : IAccountEndpoint
    {
        private const string MyAccountUrl = "/riot/account/v1/accounts/me";
        private readonly string apiKey;

        public AccountEndpoint(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public AccountDto GetAccountByPuuid(string puuid)
        {
            throw new NotImplementedException();
        }

        public AccountDto GetAccountByRiotId(string tagLine, string gameName)
        {
            throw new NotImplementedException();
        }

        public AccountDto GetActiveShards(string game, string puuid)
        {
            throw new NotImplementedException();
        }

        public AccountDto GetMyAccount()
        {

        }
    }
}
