using Newtonsoft.Json;
using System.Collections.Generic;

namespace CommonApi.Reqres.ResponseDto
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        [JsonProperty("data")]
        public List<User> Users { get; set; }
    }
}