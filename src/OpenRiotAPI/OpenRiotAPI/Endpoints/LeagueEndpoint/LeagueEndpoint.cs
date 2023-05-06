using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.LeagueEndpoint.Dtos;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.LeagueEndpoint;

public class LeagueEndpoint : EndpointBase, ILeagueEndpoint
{
    private const string ChallengerLeaguePlayersUrl = "lol/league/v4/challengerleagues/by-queue/{0}";
    private const string SummonerLeagueBySummonerIdUrl = "lol/league/v4/entries/by-summoner/{0}";
    private const string SummonersUrl = "lol/league/v4/entries/{0}/{1}/{2}";
    private const string GrandmasterLeaguePlayersUrl = "lol/league/v4/grandmasterleagues/by-queue/{0}";
    private const string LeagueByIdUrl = "lol/league/v4/leagues/{0}";
    private const string MasterLeaguePlayersUrl = "lol/league/v4/masterleagues/by-queue/{0}";
    
    public LeagueEndpoint(HttpClient httpClient) : base(httpClient)
    {
    }
    
    public Task<RiotResponse<LeagueList>> GetChallengerLeaguePlayers(Region region, string queue)
    {
        var url = RiotUri.CreateUrl(region, ChallengerLeaguePlayersUrl, queue);

        return this.httpRequester.GetAsync<LeagueList>(url);
    }

    public Task<RiotResponse<IEnumerable<LeagueEntry>>> GetSummonerLeagueBySummonerId(Region region, string summonerId)
    {
        var url = RiotUri.CreateUrl(region, SummonerLeagueBySummonerIdUrl, summonerId);

        return this.httpRequester.GetAsync<IEnumerable<LeagueEntry>>(url);
    }

    public Task<RiotResponse<IEnumerable<LeagueEntry>>> GetSummoners(Region region, string queue, string tier, string division)
    {
        var url = RiotUri.CreateUrl(region, SummonersUrl, queue, tier, division);

        return this.httpRequester.GetAsync<IEnumerable<LeagueEntry>>(url);
    }

    public Task<RiotResponse<LeagueList>> GetGrandmasterLeaguePlayers(Region region, string queue)
    {
        var url = RiotUri.CreateUrl(region, GrandmasterLeaguePlayersUrl, queue);

        return this.httpRequester.GetAsync<LeagueList>(url);
    }

    public Task<RiotResponse<LeagueList>> GetLeagueById(Region region, string leagueId)
    {
        var url = RiotUri.CreateUrl(region, LeagueByIdUrl, leagueId);

        return this.httpRequester.GetAsync<LeagueList>(url);
    }

    public Task<RiotResponse<LeagueList>> GetMasterLeaguePlayers(Region region, string queue)
    {
        var url = RiotUri.CreateUrl(region, MasterLeaguePlayersUrl, queue);

        return this.httpRequester.GetAsync<LeagueList>(url);
    }
}