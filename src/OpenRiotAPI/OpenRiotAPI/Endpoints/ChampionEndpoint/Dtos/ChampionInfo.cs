namespace OpenRiotAPI.Endpoints.ChampionEndpoint.Dtos;

public class ChampionInfo
{
    public int MaxNewPlayerLevel { get; set; }
    public IEnumerable<int> FreeChampionIdsForNewPlayers { get; set; }
    public IEnumerable<int> FreeChampionIds { get; set; }
}