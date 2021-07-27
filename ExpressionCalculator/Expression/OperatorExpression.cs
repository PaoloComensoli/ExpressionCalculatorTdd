using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public class OperatorExpression : IExpression
    {
        private readonly IExpression _acc;
        private readonly char _op;

        public OperatorExpression(IExpression acc, char op)
        {
            _acc = acc;
            _op = op;
        }


        public double Evaluate()
        {
            return 0;
        }

        //public IExpression Plus(IntExpression expression)
        //{
        //    return new PlusExpression(_acc, expression);
        //}

        public IExpression And(IntExpression expression)
        {
            return _op switch
            {
                '+' => new PlusExpression(_acc, expression),
                '-' => new MinusExpression(_acc, expression),
                _ => throw new NotImplementedException(),
            };
        }

    }
}
