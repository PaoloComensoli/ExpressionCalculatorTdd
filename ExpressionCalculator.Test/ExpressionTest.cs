using System;
using ExpressionCalculator.Expression;
using Xunit;

namespace ExpressionCalculator.Test
{
    public class ExpressionTest
    {
        [Fact]
        public void CanEvaluateANumber()
        {
            var expression = Expr.Of("5");
            var actual = expression.Evaluate();
            Assert.Equal(new IntExpression(5).Evaluate(), actual);
        }

        [Fact]
        public void CanParseASum()
        {
            var expression = Expr.Of(("2+3"));
            var actual = expression.Evaluate();
            Assert.Equal(new PlusExpression(new IntExpression(2), new IntExpression(3)).Evaluate(), 
                actual);
        }






    }
}
