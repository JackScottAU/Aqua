using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua.Common.IR
{
    public class Module
    {
        public string ModuleName { get; set; }

        public string[] Variables { get; set; }

        public string[] Functions { get; set; }
    }
}
