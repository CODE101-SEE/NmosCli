using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Component
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("bit_depth")]
        public int BitDepth { get; set; }
    }
}