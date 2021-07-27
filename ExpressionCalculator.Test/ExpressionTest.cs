using System;
using System.Linq.Expressions;

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

        [Theory]
        [ClassData(typeof(ExpressionTestData))]
        public void CanEvaluateAnExpression(IExpression expression, double result)
        {
            Assert.Equal(expression.Evaluate(), result);
        }

        [Theory]
        [InlineData("5", 5.0)]
        [InlineData("5+1", 6.0)]
        [InlineData("5 + 1", 6.0)]
        [InlineData("11+1", 12.0)]
        [InlineData("1+12", 13.0)]
        [InlineData("234+1", 235.0)]
        [InlineData("234+10", 244.0)]
        [InlineData("1+110", 111)]
        [InlineData("110-1", 109)]
        [InlineData("110-10", 100)]
        public void CanParseAnExpression(string expression, double expectedResult)
        {
            Assert.Equal(expectedResult,Expr.Of(expression).Evaluate());
        }
    }
}
