using Newtonsoft.Json;
using Regres.Dto;
using RestSharp.Deserializers;

namespace Regres.Response
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