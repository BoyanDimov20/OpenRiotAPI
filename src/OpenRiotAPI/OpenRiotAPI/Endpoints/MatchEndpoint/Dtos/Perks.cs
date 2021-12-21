namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class Perks
    {
        public PerkStat StatPerks { get; set; }

        public IList<PerkStyle> Styles { get; set; }
    }
}
