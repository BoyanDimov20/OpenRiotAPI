namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class Metadata
    {
        public string DataVersion { get; set; }

        public string MatchId { get; set; }

        public IList<string> ParticipantPuuids { get; set; }
    }
}
