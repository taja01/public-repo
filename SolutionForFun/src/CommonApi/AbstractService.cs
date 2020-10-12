using RestSharp;
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
            client = new RestClient(url);
        }

        public IRestResponse<TResponseDto> Get<TResponseDto>(string urlParameters)
        {
            request = new RestRequest(urlParameters, Method.GET);
            return client.Execute<TResponseDto>(request);
        }

        public async Task<IRestResponse<TResponseDto>> GetAsync<TResponseDto>(string urlParameters)
        {
            request = new RestRequest(urlParameters, Method.GET);
            return await client.ExecuteAsync<TResponseDto>(request);
        }

        public TimedRestResponse<TResponseDto> Get2<TResponseDto>(string urlParameters)
        {
            request = new RestRequest(urlParameters, Method.GET);
            var stopwatch = Stopwatch.StartNew();
            var response = client.Execute<TResponseDto>(request);
            stopwatch.Stop();
            return new TimedRestResponse<TResponseDto>() { Duration = stopwatch.Elapsed, Response = response };
        }
    }
}