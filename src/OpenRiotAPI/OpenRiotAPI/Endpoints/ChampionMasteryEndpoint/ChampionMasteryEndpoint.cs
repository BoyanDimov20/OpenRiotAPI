using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.ChampionMasteryEndpoint.Dtos;
using OpenRiotAPI.Endpoints.SummonerEndpoint;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.ChampionMasteryEndpoint;

public class ChampionMasteryEndpoint : EndpointBase, IChampionMasteryEndpoint
{
    private readonly ISummonerEndpoint summonerEndpoint;
    private const string AllBySummonerIdUrl = "lol/champion-mastery/v4/champion-masteries/by-summoner/{0}";
    private const string ChampionBySummonerIdUrl = "lol/champion-mastery/v4/champion-masteries/by-summoner/{0}/by-champion/{1}";
    private const string HighestMasteryBySummonerIdUrl = "lol/champion-mastery/v4/champion-masteries/by-summoner/{0}/top";
    private const string SummonerMasteryBySummonerIdUrl = "lol/champion-mastery/v4/scores/by-summoner/{0}";
    public ChampionMasteryEndpoint(HttpClient httpClient, ISummonerEndpoint summonerEndpoint) : base(httpClient)
    {
        this.summonerEndpoint = summonerEndpoint;
    }
    
    public Task<RiotResponse<IEnumerable<ChampionMastery>>> GetAllBySummonerId(Region region, string summonerId)
    {
        var url = RiotUri.CreateUrl(region, AllBySummonerIdUrl, summonerId);

        return this.httpRequester.GetAsync<IEnumerable<ChampionMastery>>(url);
    }

    public Task<RiotResponse<ChampionMastery>> GetChampionBySummonerId(Region region, string summonerId, string championId)
    {
        var url = RiotUri.CreateUrl(region, ChampionBySummonerIdUrl, summonerId, championId);

        return this.httpRequester.GetAsync<ChampionMastery>(url);
    }

    public Task<RiotResponse<IEnumerable<ChampionMastery>>> GetHighestMasteryBySummonerId(Region region, string summonerId)
    {
        var url = RiotUri.CreateUrl(region, HighestMasteryBySummonerIdUrl, summonerId);

        return this.httpRequester.GetAsync<IEnumerable<ChampionMastery>>(url);
    }

    public Task<RiotResponse<int>> GetSummonerMasteryBySummonerId(Region region, string summonerId)
    {
        var url = RiotUri.CreateUrl(region, SummonerMasteryBySummonerIdUrl, summonerId);

        return this.httpRequester.GetIConvertibleAsync<int>(url);
    }

    public async Task<RiotResponse<IEnumerable<ChampionMastery>>> GetAllBySummonerName(Region region, string summonerName)
    {
        var summoner = await summonerEndpoint.GetSummonerByName(summonerName, region);
        if (!summoner.IsSucessful)
        {
            var result = new RiotResponse<IEnumerable<ChampionMastery>>
            {
                ErrorMessage = summoner.ErrorMessage
            };
            return result;
        }

        return await GetAllBySummonerId(region, summoner.Result.Id);
    }

    public async Task<RiotResponse<ChampionMastery>> GetChampionBySummonerName(Region region, string summonerName, string championId)
    {
        var summoner = await summonerEndpoint.GetSummonerByName(summonerName, region);
        if (!summoner.IsSucessful)
        {
            var result = new RiotResponse<ChampionMastery>
            {
                ErrorMessage = summoner.ErrorMessage
            };
            return result;
        }

        return await GetChampionBySummonerId(region, summoner.Result.Id, championId);
    }

    public async Task<RiotResponse<IEnumerable<ChampionMastery>>> GetHighestMasteryBySummonerName(Region region, string summonerName)
    {
        var summoner = await summonerEndpoint.GetSummonerByName(summonerName, region);
        if (!summoner.IsSucessful)
        {
            var result = new RiotResponse<IEnumerable<ChampionMastery>>
            {
                ErrorMessage = summoner.ErrorMessage
            };
            return result;
        }

        return await GetHighestMasteryBySummonerId(region, summoner.Result.Id);
    }

    public async Task<RiotResponse<int>> GetSummonerMasteryBySummonerName(Region region, string summonerName)
    {
        var summoner = await summonerEndpoint.GetSummonerByName(summonerName, region);
        if (!summoner.IsSucessful)
        {
            var result = new RiotResponse<int>
            {
                ErrorMessage = summoner.ErrorMessage
            };
            return result;
        }

        return await GetSummonerMasteryBySummonerId(region, summoner.Result.Id);
    }
}