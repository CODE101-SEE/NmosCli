using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Api
    {
        [JsonProperty("versions")]
        public List<string> Versions { get; set; }

        [JsonProperty("endpoints")]
        public List<Endpoint> Endpoints { get; set; }
    }
}