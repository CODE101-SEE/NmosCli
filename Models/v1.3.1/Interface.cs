using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Interface
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("chassis_id")]
        public string ChassisId { get; set; }

        [JsonProperty("port_id")]
        public string PortId { get; set; }

        [JsonProperty("attached_network_device")]
        public AttachedNetworkDevice AttachedNetworkDevice { get; set; }
    }
}