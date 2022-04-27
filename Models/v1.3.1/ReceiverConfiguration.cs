using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class ReceiverConfiguration
    {
        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        [JsonProperty("master_enable")]
        public bool MasterEnable { get; set; }

        [JsonProperty("activation")]
        public Activation Activation { get; set; } = new Activation();

        [JsonProperty("transport_params")]
        public List<ReceiverTransportParam> TransportParams { get; set; } = new List<ReceiverTransportParam>();
    }
}