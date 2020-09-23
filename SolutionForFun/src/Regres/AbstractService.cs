using RestSharp;

namespace Regres
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
    }
}