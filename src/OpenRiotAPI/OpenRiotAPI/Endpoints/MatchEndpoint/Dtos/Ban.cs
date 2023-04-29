using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos;

public class Ban
{
    [JsonProperty("championId")] 
    public long ChampionId { get; set; }

    [JsonProperty("pickTurn")] 
    public long PickTurn { get; set; }
}