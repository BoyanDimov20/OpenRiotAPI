using OpenRiotAPI.Common;
using System.Text;

namespace OpenRiotAPI.Tools
{
    public class RiotUri
    {
        private const string RiotHost = "https://{0}.api.riotgames.com/{1}";
        public static string CreateUrl(Region region, string endpoint)
        {
            return String.Format(RiotHost, RiotUri.Parse(region), endpoint);
        }

        public static string CreateUrl(Region region, string endpoint, params string[] pathParams)
        {
            var endpointWithParams = String.Format(endpoint, pathParams);
            var sb = new StringBuilder(String.Format(RiotHost, RiotUri.Parse(region), endpointWithParams));
           

            return sb.ToString().TrimEnd();
        }

        public static string CreateUrl(LongRegion region, string endpoint, params string[] pathParams)
        {
            var endpointWithParams = String.Format(endpoint, pathParams);
            var sb = new StringBuilder(String.Format(RiotHost, region.ToString().ToLower(), endpointWithParams));

            return sb.ToString().TrimEnd();
        }

        private static string Parse(Region region)
        {
            switch (region)
            {
                case Region.EUNE:
                    return "eun1";
                case Region.EUW:
                    return "euw1";
                case Region.BR:
                    return "br1";
                case Region.JP:
                    return "jp1";
                case Region.KR:
                    return "kr";
                case Region.LA1:
                    return "la1";
                case Region.LA2:
                    return "la2";
                case Region.NA:
                    return "na1";
                case Region.OC:
                    return "oc1";
                case Region.RU:
                    return "ru";
                case Region.TR:
                    return "tr";
                default:
                    throw new InvalidOperationException(nameof(Region));
            }
        }
    }
}
