namespace OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos
{
    public class Perk
    {
        public IList<long> PerkIds { get; set; }

        public long PerkStyle { get; set; }

        public long PerkSubStyle { get; set; }
    }
}
