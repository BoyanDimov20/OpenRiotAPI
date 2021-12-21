using OpenRiotAPI.Common;
using OpenRiotAPI.Endpoints.MatchEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.MatchEndpoint
{
    public interface IMatchEndpoint
    {
        public Task<RiotResponse<Match>> GetMatchById(string matchId, LongRegion region);

        public Task<RiotResponse<List<string>>> GetMatchesByPuuid(string puuid, LongRegion region, long? startTime = null, long? endTime = null, int? queue = null, string type = null, int? start = null, int? count = null);

        public object GetMatchTimeline(string matchId);
    }
}
