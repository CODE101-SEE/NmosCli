using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Channel
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}