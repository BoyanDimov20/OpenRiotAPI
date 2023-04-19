using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.LeagueEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.LeagueEndpoint;

public interface ILeagueEndpoint
{
    Task<RiotResponse<LeagueList>> GetChallengerLeaguePlayers(Region region, string queue);
    Task<RiotResponse<IEnumerable<LeagueEntry>>> GetSummonerLeagueBySummonerId(Region region, string summonerId);

    Task<RiotResponse<IEnumerable<LeagueEntry>>>
        GetSummoners(Region region, string queue, string tier, string division);

    Task<RiotResponse<LeagueList>> GetGrandmasterLeaguePlayers(Region region, string queue);
    Task<RiotResponse<LeagueList>> GetLeagueById(Region region, string leagueId);
    Task<RiotResponse<LeagueList>> GetMasterLeaguePlayers(Region region, string queue);
}