using Newtonsoft.Json;
using CommonApi.Regres.Dto;
using RestSharp.Deserializers;

namespace CommonApi.Regres.Response
{
    public class UserResponse
    {
        [DeserializeAs(Name = "data")]
        [JsonProperty("data")]
        public User User { get; set; }

        [DeserializeAs(Name = "ad")]
        [JsonProperty("ad")]
        public WorkPlace WorkPlace { get; set; }
    }
}