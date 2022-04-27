using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Subscription
    {
        [JsonProperty("max_update_rate_ms")]
        public int MaxUpdateRateMs { get; set; }

        [JsonProperty("resource_path")]
        public string ResourcePath { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }

        [JsonProperty("persist")]
        public bool Persist { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }

        [JsonProperty("authorization")]
        public bool Authorization { get; set; }

        [JsonProperty("ws_href")]
        public string WsHref { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}