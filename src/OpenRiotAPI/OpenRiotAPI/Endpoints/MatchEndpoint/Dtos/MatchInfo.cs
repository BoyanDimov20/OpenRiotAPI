using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class MatchInfo
    {
        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        [JsonProperty("gameEndTimestamp")]
        public long GameEndTimestamp { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("gameName")]
        public string GameName { get; set; }

        [JsonProperty("gameStartTimestamp")]
        public long GameStartTimestamp { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }

        [JsonProperty("participants")]
        public Participant[] Participants { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("queueId")]
        public long QueueId { get; set; }

        [JsonProperty("teams")]
        public TeamInfo[] Teams { get; set; }

        [JsonProperty("tournamentCode")]
        public string TournamentCode { get; set; }

    }
}
