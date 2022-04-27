using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class TransportFile
    {
        public const string SdpType = "application/sdp";

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
