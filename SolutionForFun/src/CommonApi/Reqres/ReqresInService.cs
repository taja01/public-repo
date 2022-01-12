using CommonApi.Reqres.ResponseDto;
using RestSharp;
using System.Threading.Tasks;

namespace CommonApi.Reqres
{
    public class ReqresInService : AbstractService
    {
        public ReqresInService() : base("https://reqres.in/api/")
        {
        }

        public Task<RestResponse<UserResponse>> GetUser(string userId)
        {
            return GetAsync<UserResponse>($"users/{userId}");

        }

        public Task<RestResponse<UserListResponse>> GetUserList()
        {
            return GetAsync<UserListResponse>("users?page=2");
        }

        public Task<TimedRestResponse<UserListResponse>> GetTimedDelayedUsers(int delay)
        {
            return GetTimedResponse<UserListResponse>($"users?delay={delay}");
        }

        public Task<RestResponse<UserListResponse>> GetDelayedUsers(int delay)
        {
            return GetAsync<UserListResponse>($"users?delay={delay}");
        }
    }
}
