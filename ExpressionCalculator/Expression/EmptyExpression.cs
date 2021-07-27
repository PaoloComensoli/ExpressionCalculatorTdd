﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator.Expression
{
    public class EmptyExpression : IExpression
    {
        public double Evaluate()
        {
            return 0;
        }
        public IExpression And(IntExpression expr)
        {
            return expr;
        }
    }
}
