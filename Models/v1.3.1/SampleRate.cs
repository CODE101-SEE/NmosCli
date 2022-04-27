using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class SampleRate
    {
        [JsonProperty("numerator")]
        public int Numerator { get; set; }
    }
}