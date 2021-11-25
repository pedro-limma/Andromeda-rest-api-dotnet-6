using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Domain.Core.ValueObjects.IO.Input
{
    public record TodoReq
    {
        public string Name { get; set; }
    }
}
