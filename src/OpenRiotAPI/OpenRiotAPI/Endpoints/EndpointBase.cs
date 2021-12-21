using OpenRiotAPI.Tools;

namespace OpenRiotAPI.Endpoints
{
    public abstract class EndpointBase
    {
        internal readonly HttpRequester httpRequester;

        public EndpointBase(HttpClient httpClient)
        {
            this.httpRequester = new HttpRequester(httpClient);
        }
    }
}
