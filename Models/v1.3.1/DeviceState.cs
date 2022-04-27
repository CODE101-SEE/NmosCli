using System.Collections.Generic;

namespace Nmos.Models.v1._3._1
{
    public class DeviceState
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public Tags Tags { get; set; }

        public List<Sender> Senders { get; set; }

        public List<Receiver> Receivers { get; set; }

        public List<Control> Controls { get; set; }

        public Node Node { get; set; }
    }
}
