namespace OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos
{
    public class CurrentGame
    {
        public long GameId { get; set; }

        public string GameType { get; set; }

        public long GameStartTime { get; set; }

        public long MapId { get; set; }

        public long GameLength { get; set; }

        public string PlatformId { get; set; }

        public string GameMode { get; set; }

        public IList<BannedChampion> BannedChampions { get; set; }

        public long GameQueueConfigId { get; set; }

        public IList<CurrentGameParticipant> Participants { get; set; }
    }
}
