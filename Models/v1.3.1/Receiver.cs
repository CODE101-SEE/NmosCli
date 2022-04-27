using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Receiver
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("caps")]
        public Caps Caps { get; set; }

        [JsonProperty("subscription")]
        public SenderSubscription Subscription { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("transport")]
        public string Transport { get; set; }

        [JsonProperty("interface_bindings")]
        public List<string> InterfaceBindings { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
    }
}