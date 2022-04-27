using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Endpoint
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("authorization")]
        public bool? Authorization { get; set; }
    }
}