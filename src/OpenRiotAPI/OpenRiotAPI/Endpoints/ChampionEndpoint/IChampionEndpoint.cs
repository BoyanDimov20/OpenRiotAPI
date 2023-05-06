using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.ChampionEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.ChampionEndpoint;

public interface IChampionEndpoint
{
    Task<RiotResponse<ChampionInfo>> GetChampionRotation(Region region);
}