using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public class IntExpression : IExpression
    {
        private readonly int _value;

        public IntExpression(int value)
        {
            _value = value;
        }

        public IntExpression(double value)
        {
            _value = (int) value;
        }

        public double Evaluate()
        {
            return _value;
        }

        public IExpression Plus(IntExpression expression)
        {
            return expression;
        }

        public IExpression And(IntExpression expr)
        {
            return new IntExpression(_value * 10 + expr._value);
        }
    }
}
