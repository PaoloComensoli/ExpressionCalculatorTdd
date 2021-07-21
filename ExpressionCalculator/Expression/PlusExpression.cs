using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public class PlusExpression : IExpression
    {
        private readonly IExpression _firstAddend;
        private readonly IExpression _secondAddend;

        public PlusExpression(IExpression firstAddend, IExpression secondAddend)
        {
            _firstAddend = firstAddend;
            _secondAddend = secondAddend;
        }

        public double Evaluate()
        {
            return _firstAddend.Evaluate() + _secondAddend.Evaluate();
        }
    }
}
