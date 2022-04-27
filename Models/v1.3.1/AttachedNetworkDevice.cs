using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class AttachedNetworkDevice
    {
        [JsonProperty("chassis_id")]
        public string ChassisId { get; set; }

        [JsonProperty("port_id")]
        public string PortId { get; set; }
    }
}