using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua.Common.IR.Statements;

namespace Aqua.Common.IR
{
    public class Block
    {
        IStatement[] Statements { get; set; }

        Variable[] LocalVariables { get; set; }
    }
}
