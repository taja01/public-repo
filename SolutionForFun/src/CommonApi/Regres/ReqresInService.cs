using CommonApi.Regres.Response;
using RestSharp;

namespace CommonApi.Regres
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
    }
}
