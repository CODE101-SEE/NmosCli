using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Node
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("api")]
        public Api Api { get; set; }

        [JsonProperty("services")]
        public List<Service> Services { get; set; }

        [JsonProperty("caps")]
        public Caps Caps { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clocks")]
        public List<Clock> Clocks { get; set; }

        [JsonProperty("interfaces")]
        public List<Interface> Interfaces { get; set; }
    }
}