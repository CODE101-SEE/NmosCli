using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Control
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("authorization")]
        public bool Authorization { get; set; }
    }
}