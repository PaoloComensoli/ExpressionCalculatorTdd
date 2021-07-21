using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public static class Expr
    {
        public static IExpression Of(in string expressionStr)
        {
            return new IntExpression(int.Parse(expressionStr));
        }
    }
}
