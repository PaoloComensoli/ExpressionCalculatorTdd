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
            return expressionStr.Aggregate(new EmptyExpression() as IExpression, (expression, c) =>
            {
                if (char.IsDigit(c)) return expression.Plus(new IntExpression(int.Parse(c.ToString())));
                return new OperatorExpression(expression, c);

            });
        }
    }

    
}
