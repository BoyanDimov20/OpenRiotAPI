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

            var response = await this.httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = await response.Content.ReadAsStringAsync();
            }

            var jsonResult = await response.Content.ReadAsStringAsync();
            responseModel.Result = JsonConvert.DeserializeObject<T>(jsonResult);

            return responseModel;
        }

        public async Task<RiotResponse<T>> GetAsync<T>(string url, string authorization)
        {
            var responseModel = new RiotResponse<T>();
            httpClient.DefaultRequestHeaders.Add("Authorization", authorization);

            var response = await this.httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = await response.Content.ReadAsStringAsync();
            }

            var jsonResult = await response.Content.ReadAsStringAsync();
            responseModel.Result = JsonConvert.DeserializeObject<T>(jsonResult);

            httpClient.DefaultRequestHeaders.Remove("Authorization");

            return responseModel;
        }
    }
}
