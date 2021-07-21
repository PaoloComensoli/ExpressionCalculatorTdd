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
        private readonly IExpression _secondAdded;

        public PlusExpression(IExpression firstAddend, IExpression secondAdded)
        {
            _firstAddend = firstAddend;
            _secondAdded = secondAdded;
        }

        public double Evaluate()
        {
            return _firstAddend.Evaluate() + _secondAdded.Evaluate();
        }
    }
}
