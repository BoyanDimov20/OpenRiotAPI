using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.MatchEndpoint.Dtos;
using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints.MatchEndpoint
{
    public class MatchEndpoint : EndpointBase, IMatchEndpoint
    {
        private const string MatchByIdUrl = "lol/match/v5/matches";
        private const string MatchByPuuidUrl = "lol/match/v5/matches/by-puuid";

        public MatchEndpoint(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task<RiotResponse<Match>> GetMatchById(string matchId, LongRegion region)
        {
            return this.httpRequester.GetAsync<Match>(RiotUri.CreateUrl(region, MatchByIdUrl, matchId));
        }

        public Task<RiotResponse<List<string>>> GetMatchesByPuuid(string puuid, LongRegion region, long? startTime = null, long? endTime = null, int? queue = null, string type = null, int? start = null, int? count = null)
        {
            return this.httpRequester.GetAsync<List<string>>(RiotUri.CreateUrl(region, MatchByPuuidUrl, puuid, "ids"));
        }

        public object GetMatchTimeline(string matchId)
        {
            throw new NotImplementedException();
        }
    }
}
