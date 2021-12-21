namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class MatchInfo
    {
        public long GameCreation { get; set; }

        public long GameDuration { get; set; }

        public long GameEndTimestamp { get; set; }

        public long GameId { get; set; }

        public string GameMode { get; set; }

        public string GameName { get; set; }

        public long GameStartTimestamp { get; set; }

        public string GameType { get; set; }

        public string GameVersion { get; set; }

        public int MapId { get; set; }

        public IList<Participant> Participants { get; set; } // TODO: Participants

        public string PlatformId { get; set; }

        public int QueueId { get; set; }

        //public IList<object> Teams { get; set; } // TODO: Teams

        public string TournamentCode { get; set; }

    }
}
