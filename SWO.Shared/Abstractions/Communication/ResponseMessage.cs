using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWO.Shared.Abstractions.Communication
{
    public class ResponseMessage
    {
        public bool Successful { get; set; }

        public int? AffectedId { get; set; }

        public string? Error { get; set; }
    }
}
