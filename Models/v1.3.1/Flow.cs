using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nmos.Models.v1._3._1
{
    public class Flow
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("parents")]
        public List<string> Parents { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("sample_rate")]
        public SampleRate SampleRate { get; set; }

        [JsonProperty("frame_width")]
        public int FrameWidth { get; set; }

        [JsonProperty("frame_height")]
        public int FrameHeight { get; set; }

        [JsonProperty("interlace_mode")]
        public string InterlaceMode { get; set; }

        [JsonProperty("colorspace")]
        public string Colorspace { get; set; }

        [JsonProperty("components")]
        public List<Component> Components { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }
    }
}