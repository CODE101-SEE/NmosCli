using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class SenderTransportParam
    {
        [JsonProperty("destination_ip")]
        public string DestinationIp { get; set; } = "auto";

        [JsonProperty("destination_port")]
        public int DestinationPort { get; set; }

        [JsonProperty("rtp_enabled")]
        public bool RtpEnabled { get; set; } = true;

        [JsonProperty("source_ip")]
        public string SourceIp { get; set; } = "auto";

        [JsonProperty("source_port")]
        public int SourcePort { get; set; }
    }
}