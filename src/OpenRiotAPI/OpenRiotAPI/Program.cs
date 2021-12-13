using OpenRiotAPI;
using OpenRiotAPI.Common;

var riotClient = new RiotClient("RGAPI-41e272f6-5907-48f0-b62a-001bd782473b");

var summoner = await riotClient.Summoners.GetSummonerByName("sorion99", Region.EUNE);
Console.WriteLine(summoner.Result.Name);

var spectate = await riotClient.Spectator.GetActiveGameBySummonerName("Ivan", Region.EUNE);
Console.WriteLine(spectate.Result.BannedChampions);
