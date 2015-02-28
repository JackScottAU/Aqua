using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua.Common.IR
{
    public class Function
    {
        public string Name { get; set; }

        public Variable[] Parameters { get; set; }

        public Block Code { get; set; }

        public DataType Returns { get; set; }
    }
}
