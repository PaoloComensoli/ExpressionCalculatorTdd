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

        public double Evaluate()
        {
            return _value;
        }
    }
}
