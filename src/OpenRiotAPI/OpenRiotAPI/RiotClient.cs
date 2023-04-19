using OpenRiotAPI.Endpoints.AccountEndpoint;
using OpenRiotAPI.Endpoints.ChampionMasteryEndpoint;
using OpenRiotAPI.Endpoints.LeagueEndpoint;
using OpenRiotAPI.Endpoints.MatchEndpoint;
using OpenRiotAPI.Endpoints.SpectatorEndpoint;
using OpenRiotAPI.Endpoints.SummonerEndpoint;

namespace OpenRiotAPI
{
    public class RiotClient : IDisposable
    {
        private readonly string apiKey;
        private readonly HttpClient httpClient;
        private readonly bool isDisposable = false;

        public ISummonerEndpoint Summoners { get; }
        public ISpectatorEndpoint Spectator { get; }
        public IMatchEndpoint Matches { get; }
        public IAccountEndpoint Accounts { get; }
        public IChampionMasteryEndpoint ChampionMastery { get; }
        public ILeagueEndpoint Leagues { get; set; }

        public RiotClient(string apiKey)
        {
            this.apiKey = apiKey;
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("X-Riot-Token", apiKey);
            this.isDisposable = true;

            this.Summoners = new SummonerEndpoint(httpClient);
            this.Spectator = new SpectatorEndpoint(httpClient);
            this.Matches = new MatchEndpoint(httpClient);
            this.Accounts = new AccountEndpoint(httpClient);
            this.ChampionMastery = new ChampionMasteryEndpoint(httpClient, Summoners);
            this.Leagues = new LeagueEndpoint(httpClient);
        }

        public RiotClient(HttpClient client)
        {
            this.httpClient = client;

            this.Summoners = new SummonerEndpoint(httpClient);
            this.Spectator = new SpectatorEndpoint(httpClient);
            this.Matches = new MatchEndpoint(httpClient);
            this.Accounts = new AccountEndpoint(httpClient);
            this.ChampionMastery = new ChampionMasteryEndpoint(httpClient, Summoners);
            this.Leagues = new LeagueEndpoint(httpClient);
        }

        public void Dispose()
        {
            if (isDisposable)
            {
                this.httpClient.Dispose();
            }
        }
    }
}