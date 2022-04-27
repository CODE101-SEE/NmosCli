using System;
using System.Collections.Generic;
using System.Linq;

namespace Nmos.Models.Inputs
{
    public class NmosResponse
    {
        public string Endpoint { get; set; } = string.Empty;
        public bool Success { get; set; }
        public IEnumerable<Exception> Exceptions { get; set; } = Enumerable.Empty<Exception>();
    }
}
