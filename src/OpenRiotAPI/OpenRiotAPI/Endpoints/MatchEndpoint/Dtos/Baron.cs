using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos;

public class Baron
{
    [JsonProperty("first")]
    public bool First { get; set; }

    [JsonProperty("kills")]
    public long Kills { get; set; }
}