namespace OpenRiotAPI
{
    public class RiotClient
    {
        private readonly string apiKey;

        private readonly HttpClient httpClient;

        public RiotClient(string apiKey)
        {
            this.apiKey = apiKey;
            this.httpClient = new HttpClient();
        }


    }
}
