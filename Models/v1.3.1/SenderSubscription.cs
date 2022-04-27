using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nmos.Models.v1._3._1
{
    public class SenderSubscription
    {
        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> Extension { get; set; }
    }
}