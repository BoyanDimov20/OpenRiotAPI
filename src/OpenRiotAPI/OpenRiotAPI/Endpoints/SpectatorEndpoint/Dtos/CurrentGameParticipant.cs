using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.SpectatorEndpoint.Dtos
{
    public class CurrentGameParticipant
    {
        public long ChampionId { get; set; }

        public Perk Perks { get; set; }

        public long ProfileIconId { get; set; }

        [JsonProperty("bot")]
        public bool IsBot { get; set; }

        public long TeamId { get; set; }

        public string SummonerName { get; set; }

        public string SummonerId { get; set; }

        public long Spell1Id { get; set; }

        public long Spell2Id { get; set; }

        public IList<GameCustomization> GameCustomizationObjects { get; set; }
    }
}
