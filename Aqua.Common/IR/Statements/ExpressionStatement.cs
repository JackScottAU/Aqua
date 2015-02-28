using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua.Common.IR.Expressions;

namespace Aqua.Common.IR.Statements
{
    public class ExpressionStatement : IStatement
    {
        public IExpression Expression { get; set; }
    }
}
