namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class PerkStyle
    {
        public string Description { get; set; }

        public int Style { get; set; }

        public IList<PerkStyleSelection> Selections { get; set; }
    }
}
