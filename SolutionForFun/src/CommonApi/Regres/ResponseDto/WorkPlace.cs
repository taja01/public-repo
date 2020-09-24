using Newtonsoft.Json;

namespace CommonApi.Regres.ResponseDto
{
    public class WorkPlace
    {
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}