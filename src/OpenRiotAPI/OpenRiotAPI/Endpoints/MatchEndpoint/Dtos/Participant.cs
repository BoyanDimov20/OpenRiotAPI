using Newtonsoft.Json;

namespace OpenRiotAPI.Endpoints.MatchEndpoint.Dtos
{
    public class Participant
    {
       [JsonProperty("allInPings")]
        public long AllInPings { get; set; }

        [JsonProperty("assistMePings")]
        public long AssistMePings { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("baitPings")]
        public long BaitPings { get; set; }

        [JsonProperty("baronKills")]
        public long BaronKills { get; set; }

        [JsonProperty("basicPings")]
        public long BasicPings { get; set; }

        [JsonProperty("bountyLevel")]
        public long BountyLevel { get; set; }

        [JsonProperty("challenges")]
        public Dictionary<string, double> Challenges { get; set; }

        [JsonProperty("champExperience")]
        public long ChampExperience { get; set; }

        [JsonProperty("champLevel")]
        public long ChampLevel { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("championName")]
        public string ChampionName { get; set; }

        [JsonProperty("championTransform")]
        public long ChampionTransform { get; set; }

        [JsonProperty("commandPings")]
        public long CommandPings { get; set; }

        [JsonProperty("consumablesPurchased")]
        public long ConsumablesPurchased { get; set; }

        [JsonProperty("damageDealtToBuildings")]
        public long DamageDealtToBuildings { get; set; }

        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        [JsonProperty("dangerPings")]
        public long DangerPings { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("detectorWardsPlaced")]
        public long DetectorWardsPlaced { get; set; }

        [JsonProperty("doubleKills")]
        public long DoubleKills { get; set; }

        [JsonProperty("dragonKills")]
        public long DragonKills { get; set; }

        [JsonProperty("eligibleForProgression")]
        public bool EligibleForProgression { get; set; }

        [JsonProperty("enemyMissingPings")]
        public long EnemyMissingPings { get; set; }

        [JsonProperty("enemyVisionPings")]
        public long EnemyVisionPings { get; set; }

        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [JsonProperty("gameEndedInEarlySurrender")]
        public bool GameEndedInEarlySurrender { get; set; }

        [JsonProperty("gameEndedInSurrender")]
        public bool GameEndedInSurrender { get; set; }

        [JsonProperty("getBackPings")]
        public long GetBackPings { get; set; }

        [JsonProperty("goldEarned")]
        public long GoldEarned { get; set; }

        [JsonProperty("goldSpent")]
        public long GoldSpent { get; set; }

        [JsonProperty("holdPings")]
        public long HoldPings { get; set; }

        [JsonProperty("individualPosition")]
        public string IndividualPosition { get; set; }

        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }

        [JsonProperty("inhibitorTakedowns")]
        public long InhibitorTakedowns { get; set; }

        [JsonProperty("inhibitorsLost")]
        public long InhibitorsLost { get; set; }

        [JsonProperty("item0")]
        public long Item0 { get; set; }

        [JsonProperty("item1")]
        public long Item1 { get; set; }

        [JsonProperty("item2")]
        public long Item2 { get; set; }

        [JsonProperty("item3")]
        public long Item3 { get; set; }

        [JsonProperty("item4")]
        public long Item4 { get; set; }

        [JsonProperty("item5")]
        public long Item5 { get; set; }

        [JsonProperty("item6")]
        public long Item6 { get; set; }

        [JsonProperty("itemsPurchased")]
        public long ItemsPurchased { get; set; }

        [JsonProperty("killingSprees")]
        public long KillingSprees { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }

        [JsonProperty("largestKillingSpree")]
        public long LargestKillingSpree { get; set; }

        [JsonProperty("largestMultiKill")]
        public long LargestMultiKill { get; set; }

        [JsonProperty("longestTimeSpentLiving")]
        public long LongestTimeSpentLiving { get; set; }

        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageTaken")]
        public long MagicDamageTaken { get; set; }

        [JsonProperty("needVisionPings")]
        public long NeedVisionPings { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }

        [JsonProperty("nexusKills")]
        public long NexusKills { get; set; }

        [JsonProperty("nexusLost")]
        public long NexusLost { get; set; }

        [JsonProperty("nexusTakedowns")]
        public long NexusTakedowns { get; set; }

        [JsonProperty("objectivesStolen")]
        public long ObjectivesStolen { get; set; }

        [JsonProperty("objectivesStolenAssists")]
        public long ObjectivesStolenAssists { get; set; }

        [JsonProperty("onMyWayPings")]
        public long OnMyWayPings { get; set; }

        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("pentaKills")]
        public long PentaKills { get; set; }

        [JsonProperty("perks")]
        public Perks Perks { get; set; }

        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        [JsonProperty("profileIcon")]
        public long ProfileIcon { get; set; }

        [JsonProperty("pushPings")]
        public long PushPings { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("quadraKills")]
        public long QuadraKills { get; set; }

        [JsonProperty("riotIdName")]
        public string RiotIdName { get; set; }

        [JsonProperty("riotIdTagline")]
        public string RiotIdTagline { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }

        [JsonProperty("spell1Casts")]
        public long Spell1Casts { get; set; }

        [JsonProperty("spell2Casts")]
        public long Spell2Casts { get; set; }

        [JsonProperty("spell3Casts")]
        public long Spell3Casts { get; set; }

        [JsonProperty("spell4Casts")]
        public long Spell4Casts { get; set; }

        [JsonProperty("summoner1Casts")]
        public long Summoner1Casts { get; set; }

        [JsonProperty("summoner1Id")]
        public long Summoner1Id { get; set; }

        [JsonProperty("summoner2Casts")]
        public long Summoner2Casts { get; set; }

        [JsonProperty("summoner2Id")]
        public long Summoner2Id { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("teamEarlySurrendered")]
        public bool TeamEarlySurrendered { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("teamPosition")]
        public string TeamPosition { get; set; }

        [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        [JsonProperty("timePlayed")]
        public long TimePlayed { get; set; }

        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [JsonProperty("totalDamageShieldedOnTeammates")]
        public long TotalDamageShieldedOnTeammates { get; set; }

        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [JsonProperty("totalHeal")]
        public long TotalHeal { get; set; }

        [JsonProperty("totalHealsOnTeammates")]
        public long TotalHealsOnTeammates { get; set; }

        [JsonProperty("totalMinionsKilled")]
        public long TotalMinionsKilled { get; set; }

        [JsonProperty("totalTimeCCDealt")]
        public long TotalTimeCcDealt { get; set; }

        [JsonProperty("totalTimeSpentDead")]
        public long TotalTimeSpentDead { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }

        [JsonProperty("tripleKills")]
        public long TripleKills { get; set; }

        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [JsonProperty("turretKills")]
        public long TurretKills { get; set; }

        [JsonProperty("turretTakedowns")]
        public long TurretTakedowns { get; set; }

        [JsonProperty("turretsLost")]
        public long TurretsLost { get; set; }

        [JsonProperty("unrealKills")]
        public long UnrealKills { get; set; }

        [JsonProperty("visionClearedPings")]
        public long VisionClearedPings { get; set; }

        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }

        [JsonProperty("visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }

        [JsonProperty("wardsKilled")]
        public long WardsKilled { get; set; }

        [JsonProperty("wardsPlaced")]
        public long WardsPlaced { get; set; }

        [JsonProperty("win")]
        public bool IsWinner { get; set; }
    }
}
