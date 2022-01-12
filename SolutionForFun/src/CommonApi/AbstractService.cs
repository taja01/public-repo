using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CommonApi
{
    public abstract class AbstractService
    {
        protected RestClient client;
        protected RestRequest request;

        protected AbstractService(string url)
        {
            var options = new RestClientOptions
            {
                BaseUrl = new System.Uri(url)
            };

            client = new RestClient(options);
        }

        public async Task<RestResponse<TResponseDto>> GetAsync<TResponseDto>(string urlParameters, IList<HeaderParameter> headers = null)
        {
            request = new RestRequest(urlParameters, Method.Get);

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Name, header.Value.ToString());
                }
            }

            return await client.ExecuteAsync<TResponseDto>(request);
        }

        public async Task<TimedRestResponse<TResponseDto>> GetTimedResponse<TResponseDto>(string urlParameters, IList<HeaderParameter> headers = null)
        {
            var stopwatch = Stopwatch.StartNew();
            var response = await this.GetAsync<TResponseDto>(urlParameters);
            stopwatch.Stop();
            return new TimedRestResponse<TResponseDto>() { Duration = stopwatch.Elapsed, Response = response };
        }
    }
}