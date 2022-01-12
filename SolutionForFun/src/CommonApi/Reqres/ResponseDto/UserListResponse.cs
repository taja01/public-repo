using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CommonApi.Reqres.ResponseDto
{
    public class UserListResponse
    {
        public int Page { get; set; }

        [JsonPropertyName("per_page")]

        public int PerPage { get; set; }

        public int Total { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("data")]
        public List<User> Users { get; set; }

        [JsonPropertyName("support")]
        public Support Support { get; set; }
    }
}