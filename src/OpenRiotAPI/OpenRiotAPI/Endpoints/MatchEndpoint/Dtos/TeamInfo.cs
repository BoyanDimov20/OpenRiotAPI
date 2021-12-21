using Newtonsoft.Json;
using OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class TeamInfo
    {
        public BannedChampion Bans { get; set; }

        public int TeamId { get; set; }

        [JsonProperty("win")]
        public bool IsWinner { get; set; }

        public Objectives Objectives { get; set; }
    }
}
