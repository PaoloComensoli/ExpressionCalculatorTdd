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
                if (char.IsDigit(c)) return expression.And(new IntExpression(int.Parse(c.ToString())));
                if (char.IsWhiteSpace(c)) return expression;
                return new OperatorExpression(expression, c);

            });
        }
    }

    
}
