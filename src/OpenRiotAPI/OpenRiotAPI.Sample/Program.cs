using System;
using System.Threading.Tasks;
using OpenRiotAPI;
using OpenRiotAPI.Common;

namespace OpenRiotAPI.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var riotClient = new RiotClient("RGAPI-20afab67-3f9f-4d23-bd42-59022fd99ce8");

            var summoner = await riotClient.Summoners.GetSummonerByName("sorion99", Region.EUNE);


            Console.WriteLine(summoner.Result.Puuid);

            var matches = await riotClient.Matches.GetMatchesByPuuid(summoner.Result.Puuid, LongRegion.Europe);


            foreach (var match in matches.Result)
            {
                var stats = await riotClient.Matches.GetMatchById(match, LongRegion.Europe);
                Console.WriteLine($"Game version: {stats.Result.MatchInfo.GameVersion}; Date: {DateTimeOffset.FromUnixTimeMilliseconds(stats.Result.MatchInfo.GameCreation).ToLocalTime()}");
            }
        }
    }
}
