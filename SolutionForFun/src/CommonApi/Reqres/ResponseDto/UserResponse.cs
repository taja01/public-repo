using System.Text.Json.Serialization;

namespace CommonApi.Reqres.ResponseDto
{
    public class UserResponse
    {
        [JsonPropertyName("data")]
        public User User { get; set; }

        [JsonPropertyName("support")]
        public Support Support { get; set; }
    }
}