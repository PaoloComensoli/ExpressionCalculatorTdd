using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public class MinusExpression : IExpression
    {
        private readonly IExpression _firstValue;
        private readonly IExpression _secondValue;

        public MinusExpression(IExpression firstValue, IExpression secondValue)
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
        }

        public double Evaluate()
        {
            return _firstValue.Evaluate() - _secondValue.Evaluate();
        }

        public IExpression Plus(IntExpression expression)
        {
            throw new NotImplementedException();
        }

        public IExpression And(IntExpression expr)
        {
            return new MinusExpression(_firstValue, _secondValue.And((expr)));
        }
    }
}
