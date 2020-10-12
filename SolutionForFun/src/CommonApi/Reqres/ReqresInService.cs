using CommonApi.Reqres.ResponseDto;
using RestSharp;

namespace CommonApi.Reqres
{
    public class ReqresInService : AbstractService
    {
        public ReqresInService() : base("https://reqres.in/api/")
        {
        }

        public IRestResponse<UserResponse> GetUser(string userId)
        {
            return base.Get<UserResponse>($"users/{userId}");

        }

        public IRestResponse<UserListResponse> GetUserList()
        {
            return base.Get<UserListResponse>("users?page=2");
        }

        public TimedRestResponse<UserListResponse> GetDelayedUsers(int delay)
        {
            return base.Get2<UserListResponse>($"users?delay={delay}");
        }

        public IRestResponse<UserListResponse> GetDelayedUsers2(int delay)
        {
            return base.GetAsync<UserListResponse>($"users?delay={delay}").Result;
        }
    }
}
