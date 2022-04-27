using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Sender
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("manifest_href")]
        public string ManifestHref { get; set; }

        [JsonProperty("flow_id")]
        public string FlowId { get; set; }

        [JsonIgnore]
        public Flow Flow { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("transport")]
        public string Transport { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("interface_bindings")]
        public List<string> InterfaceBindings { get; set; }

        [JsonProperty("caps")]
        public Caps Caps { get; set; }

        [JsonProperty("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("subscription")]
        public ReceiverSubscription Subscription { get; set; }
    }
}