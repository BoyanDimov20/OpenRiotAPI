using OpenRiotAPI.Endpoints.SpectatorEndpoint;
using OpenRiotAPI.Endpoints.SummonerEndpoint;

namespace OpenRiotAPI
{
    public class RiotClient : IDisposable
    {
        private readonly string apiKey;
        private readonly HttpClient httpClient;

        public ISummonerEndpoint Summoners { get; set; }

        public ISpectatorEndpoint Spectator { get; set; }

        public RiotClient(string apiKey)
        {
            this.apiKey = apiKey;
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("X-Riot-Token", apiKey);
            this.Summoners = new SummonerEndpoint(httpClient);
            this.Spectator = new SpectatorEndpoint(httpClient);
        }

        public void Dispose()
        {
            this.httpClient.Dispose();
        }
    }
}
