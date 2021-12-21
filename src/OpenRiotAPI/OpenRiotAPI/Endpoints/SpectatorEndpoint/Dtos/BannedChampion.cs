namespace OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos
{
    public class BannedChampion
    {
        public int PickTurn { get; set; }

        public long ChampionId { get; set; }

        public long TeamId { get; set; }
    }
}
