using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Clock
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ref_type")]
        public string RefType { get; set; }

        [JsonProperty("traceable")]
        public bool? Traceable { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("gmid")]
        public string Gmid { get; set; }

        [JsonProperty("locked")]
        public bool? Locked { get; set; }
    }
}