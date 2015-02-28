using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua.Common.IR;

namespace Aqua.Common
{
    public interface IOptimise
    {
        string OptimiserName { get; }

        Module Optimise(Module input);
    }
}
