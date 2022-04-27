using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Activation
    {
        public const string ActivateImmediate = "activate_immediate";
        public const string ActivateScheduledAbsolute = "activate_scheduled_absolute";
        public const string ActivateScheduledRelative = "activate_scheduled_relative";

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("requested_time")]
        public object RequestedTime { get; set; }
    }
}
