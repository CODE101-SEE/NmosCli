using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nmos.Models.v1._3._1
{
    public class Tags
    {
        [JsonExtensionData]
        public IDictionary<string, JToken> Extension { get; set; }
    }
}