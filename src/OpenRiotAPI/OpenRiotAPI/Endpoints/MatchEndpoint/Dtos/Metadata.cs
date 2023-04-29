using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class Metadata
    {
        [JsonProperty("dataVersion")]
        public string DataVersion { get; set; }

        [JsonProperty("matchId")]
        public string MatchId { get; set; }

        [JsonProperty("participants")]
        public string[] Participants { get; set; }
    }
}
