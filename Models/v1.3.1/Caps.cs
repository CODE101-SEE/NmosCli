using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nmos.Models.v1._3._1
{
    public class Caps
    {
        [JsonProperty("media_types")]
        public List<string> MediaTypes { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> Extension { get; set; }
    }
}