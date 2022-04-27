using System.Collections.Generic;
using System.Linq;

namespace Nmos.Models.Inputs
{
    public class GetAllResponse<T> : NmosResponse
    {
        public IEnumerable<T> Data { get; set; } = Enumerable.Empty<T>();
    }
}