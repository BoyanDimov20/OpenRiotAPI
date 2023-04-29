using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class Perks
    {
        [JsonProperty("statPerks")]
        public PerkStat StatPerks { get; set; }

        [JsonProperty("styles")]
        public IList<PerkStyle> Styles { get; set; }
    }
}
