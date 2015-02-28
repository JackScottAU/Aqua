using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua.Common.IR.Expressions;

namespace Aqua.Common.IR.Statements
{
    public class IfStatement : IStatement
    {
        public IExpression Test { get; set; }

        public Block IfTrue { get; set; }
    }
}
