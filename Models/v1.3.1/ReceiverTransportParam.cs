using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class ReceiverTransportParam
    {
        [JsonProperty("interface_ip")]
        public string InterfaceIp { get; set; }

        [JsonProperty("multicast_ip")]
        public string MulticastIp { get; set; }

        [JsonProperty("source_ip")]
        public string SourceIp { get; set; }

        [JsonProperty("destination_port")]
        public int DestinationPort { get; set; }

        [JsonProperty("rtp_enabled")]
        public bool RtpEnabled { get; set; } = true;
    }
}