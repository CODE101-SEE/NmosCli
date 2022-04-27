using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Source
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("caps")]
        public Caps Caps { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("parents")]
        public List<string> Parents { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("clock_name")]
        public string ClockName { get; set; }

        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }
    }
}