namespace OpenRiotAPI.Endpoints.ChampionMasteryEndpoint.Dtos;

public class ChampionMastery
{
    public long ChampionPointsUntilNextLevel { get; set; }
    public bool ChestGranted { get; set; }
    public long ChampionId { get; set; }
    public long LastPlayTime { get; set; }
    public int ChampionLevel { get; set; }
    public string SummonerId { get; set; }
    public int ChampionPoints { get; set; }
    public long ChampionPointsSinceLastLevel { get; set; }
    public int TokensEarned { get; set; }
}