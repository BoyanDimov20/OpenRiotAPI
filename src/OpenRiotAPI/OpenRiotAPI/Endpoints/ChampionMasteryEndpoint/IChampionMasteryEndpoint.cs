using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.ChampionMasteryEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.ChampionMasteryEndpoint;

public interface IChampionMasteryEndpoint
{
    Task<RiotResponse<IEnumerable<ChampionMastery>>> GetAllBySummonerId(Region region, string summonerId);
    Task<RiotResponse<ChampionMastery>> GetChampionBySummonerId(Region region, string summonerId, string championId);
    Task<RiotResponse<IEnumerable<ChampionMastery>>> GetHighestMasteryBySummonerId(Region region, string summonerId);
    Task<RiotResponse<int>> GetSummonerMasteryBySummonerId(Region region, string summonerId);
    
    Task<RiotResponse<IEnumerable<ChampionMastery>>> GetAllBySummonerName(Region region, string summonerName);
    Task<RiotResponse<ChampionMastery>> GetChampionBySummonerName(Region region, string summonerName, string championId);
    Task<RiotResponse<IEnumerable<ChampionMastery>>> GetHighestMasteryBySummonerName(Region region, string summonerName);
    Task<RiotResponse<int>> GetSummonerMasteryBySummonerName(Region region, string summonerName);

}