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

        public Variable[] GlobalVariables { get; set; }

        public Function[] Functions { get; set; }
    }
}
