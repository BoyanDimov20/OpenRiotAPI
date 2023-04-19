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

        internal async Task<RiotResponse<T>> GetIConvertibleAsync<T>(string url) where T : IConvertible
        {
            var responseModel = new RiotResponse<T>();

            var response = await this.httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = await response.Content.ReadAsStringAsync();
                return responseModel;
            }

            responseModel.Result = (T)Convert.ChangeType(await response.Content.ReadAsStringAsync(), typeof(T));
            return responseModel;
        }

        internal async Task<RiotResponse<string>> GetAsStringAsync(string url)
        {
            var responseModel = new RiotResponse<string>();

            var response = await this.httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = await response.Content.ReadAsStringAsync();
                return responseModel;
            }

            responseModel.Result = await response.Content.ReadAsStringAsync();
            return responseModel;
        }

        internal async Task<RiotResponse<T>> GetAsync<T>(string url) where T : class
        {
            var responseModel = new RiotResponse<T>();

            var response = await this.httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = await response.Content.ReadAsStringAsync();
                return responseModel;
            }

            var jsonResult = await response.Content.ReadAsStringAsync();
            responseModel.Result = JsonConvert.DeserializeObject<T>(jsonResult);

            return responseModel;
        }

        internal async Task<RiotResponse<T>> GetAsync<T>(string url, string authorization)
        {
            var responseModel = new RiotResponse<T>();
            httpClient.DefaultRequestHeaders.Add("Authorization", authorization);

            var response = await this.httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                responseModel.ErrorMessage = await response.Content.ReadAsStringAsync();
                return responseModel;
            }

            var jsonResult = await response.Content.ReadAsStringAsync();
            responseModel.Result = JsonConvert.DeserializeObject<T>(jsonResult);

            httpClient.DefaultRequestHeaders.Remove("Authorization");

            return responseModel;
        }
    }
}
