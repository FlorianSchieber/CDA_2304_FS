using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public abstract class BinaryOperator : Expression
    {
        protected Expression leftOperand;
        protected Expression rightOperand;

        public BinaryOperator(Expression leftOperand, Expression rightOperand)
        {
            this.leftOperand = leftOperand;
            this.rightOperand = rightOperand;
        }
    }
}
