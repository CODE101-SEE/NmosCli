using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class RegistrationHealth
    {
        [JsonProperty("health")]
        public string Health { get; set; }
    }
}