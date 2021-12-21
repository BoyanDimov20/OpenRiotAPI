using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class Match
    {
        public Metadata Metadata { get; set; }

        [JsonProperty("info")]
        public MatchInfo MatchInfo { get; set; }
    }
}
