using CommonApi.Regres.Dto;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CommonApi.Regres.Response
{
    public class UserListResponse
    {
        public int Page { get; set; }
        [JsonProperty("per_page")]
        [DeserializeAs(Name = "per_page")]
        public int PerPage { get; set; }
        public int Total { get; set; }
        [JsonProperty("total_pages")]
        [DeserializeAs(Name = "total_pages")]
        public int TotalPages { get; set; }
        [DeserializeAs(Name = "data")]
        public List<User> Users { get; set; }
        [DeserializeAs(Name = "ad")]
        [JsonProperty("ad")]
        public WorkPlace WorkPlace { get; set; }
    }
}