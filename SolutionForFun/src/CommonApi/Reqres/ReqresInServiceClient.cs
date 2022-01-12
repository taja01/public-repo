using CommonApi.Reqres.ResponseDto;
using RestSharp;
using System.Threading.Tasks;

namespace CommonApi.Reqres
{
    public class ReqresInServiceClient
    {
        private RestClient _restClient;
        public ReqresInServiceClient()
        {
            _restClient = new RestClient("https://reqres.in/api/");
        }

        public Task<RestResponse<UserResponse>> GetUser(string userId)
        {
            var request = new RestRequest($"users/{userId}", Method.Get);
            return _restClient.ExecuteAsync<UserResponse>(request);

        }

        public Task<RestResponse<UserListResponse>> GetUserList()
        {
            var request = new RestRequest("users?page=2", Method.Get);
            return _restClient.ExecuteAsync<UserListResponse>(request);
        }

        public Task<RestResponse<UserListResponse>> GetDelayedUsers(int delay)
        {
            var request = new RestRequest($"users?delay={delay}", Method.Get);

            return _restClient.ExecuteAsync<UserListResponse>(request);
        }
    }
}
