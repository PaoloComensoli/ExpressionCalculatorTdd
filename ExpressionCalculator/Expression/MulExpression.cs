using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public class MulExpression : IExpression
    {
        private readonly IExpression _firstValue;
        private readonly IExpression _secondValue;

        public MulExpression(IExpression firstValue, IExpression secondValue)
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
        }

        public double Evaluate()
        {
            return _firstValue.Evaluate() * _secondValue.Evaluate();
        }

        public IExpression And(IntExpression expr)
        {
            return new MulExpression(_firstValue, _secondValue.And((expr)));
        }
    }
}
