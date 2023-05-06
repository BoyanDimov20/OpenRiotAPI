namespace OpenRiotAPI.Extensions
{
    public class RiotClientOptions
    {
        private string _apiKey;

        public RiotClientOptions()
        {
        }
        
        public string ApiKey
        {
            set => this._apiKey = value ?? throw new ArgumentNullException(nameof(value));
            get => _apiKey;
        }
    }
}