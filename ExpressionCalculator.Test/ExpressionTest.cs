using System;
using ExpressionCalculator.Expression;
using Xunit;

namespace ExpressionCalculator.Test
{
    public class ExpressionTest
    {
        [Fact]
        public void CanEvaluateAndExpression()
        {
            var expression = Expr.Of("5");
            var actual = expression.Evaluate();
            Assert.Equal(new IntExpression(5).Evaluate(), actual);
        }






    }
}
