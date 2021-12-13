using Newtonsoft.Json;
using OpenRiotAPI.Common;

namespace OpenRiotAPI.Tools
{
    internal class HttpRequester
    {
        private readonly HttpClient httpClient;

        public HttpRequester(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<RiotResponse<T>> GetAsync<T>(string url)
        {
            var responseModel = new RiotResponse<T>();

            var response = this.httpClient.GetAsync(url).GetAwaiter().GetResult();
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            var jsonResult = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            responseModel.Result = JsonConvert.DeserializeObject<T>(jsonResult);

            return responseModel;
        }
    }
}
