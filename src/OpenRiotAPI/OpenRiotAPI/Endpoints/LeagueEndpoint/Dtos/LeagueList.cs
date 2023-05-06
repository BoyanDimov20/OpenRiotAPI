namespace OpenRiotAPI.Endpoints.LeagueEndpoint.Dtos;

public class LeagueList
{
    public string LeagueId { get; set; }

    public IEnumerable<LeagueItem> Entries { get; set; }

    public string Tier { get; set; }

    public string Name { get; set; }

    public string Queue { get; set; }
}