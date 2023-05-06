using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.ChampionEndpoint.Dtos;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.ChampionEndpoint;

public class ChampionEndpoint : EndpointBase, IChampionEndpoint
{
    private const string ChampionRotationUrl = "lol/platform/v3/champion-rotations";
        
    public ChampionEndpoint(HttpClient httpClient) : base(httpClient)
    {
    }
    
    public Task<RiotResponse<ChampionInfo>> GetChampionRotation(Region region)
    {
        var url = RiotUri.CreateUrl(region, ChampionRotationUrl);

        return this.httpRequester.GetAsync<ChampionInfo>(url);
    }

    
}