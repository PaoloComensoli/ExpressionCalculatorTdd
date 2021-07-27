using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressionCalculator.Expression;

namespace ExpressionCalculator.Test
{
    public class ExpressionTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new IntExpression(5), 5.0 };
            yield return new object[] { new PlusExpression(new IntExpression(5), new IntExpression(1)), 6.0 };
            yield return new object[] { new MinusExpression(new IntExpression(5), new IntExpression(1)), 4.0 };
            yield return new object[] { new PlusExpression(new IntExpression(5), new PlusExpression(new IntExpression(1), new IntExpression(2))), 8.0 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
