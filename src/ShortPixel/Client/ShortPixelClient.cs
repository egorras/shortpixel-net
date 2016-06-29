using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShortPixel.Serializers;

namespace ShortPixel.Client
{
    /// <summary>
    /// ShortPixel API client.
    /// <see cref="https://shortpixel.com/api-docs"/>
    /// </summary>
    public class ShortPixelClient : IShortPixelClient
    {
        private readonly IRestClient restClient;

        private const string ApiUrl = "https://api.shortpixel.com";
        private const string ReducerUrl = "/v2/reducer.php";

        /// <summary>
        /// Initialize ShortPixel API client.
        /// </summary>
        public ShortPixelClient()
            : this(new RestClient())
        {
        }

        internal ShortPixelClient(IRestClient restClient)
        {
            this.restClient = restClient;

            SetupRestClient();
        }

        private void SetupRestClient()
        {
            restClient.BaseUrl = new Uri(ApiUrl);
        }

        /// <summary>
        /// Shrink an image based on the URL of the image. The image has to be available online in order to be shrunk via this API.
        /// </summary>
        public IList<ReducerResponse> Reducer(ReducerRequest reducerRequest)
        {
            var request = CreateRestRequest(reducerRequest);
            var response = restClient.Execute<List<ReducerResponse>>(request);
            return response.Data;
        }

        /// <summary>
        /// Shrink an image based on the URL of the image. The image has to be available online in order to be shrunk via this API.
        /// </summary>
        public async Task<IList<ReducerResponse>> ReducerAsync(ReducerRequest reducerRequest)
        {
            var request = CreateRestRequest(reducerRequest);
            var response = await restClient.ExecuteTaskAsync<List<ReducerResponse>>(request).ConfigureAwait(false);
            return response.Data;
        }

        private IRestRequest CreateRestRequest(ReducerRequest reducerRequest)
        {
            var request = new RestRequest(ReducerUrl, Method.POST)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = NewtonsoftJsonSerializer.Default,
                OnBeforeDeserialization = r => { r.ContentType = "application/json"; }
            };
            request.AddJsonBody(reducerRequest);
            return request;
        }
    }
}
