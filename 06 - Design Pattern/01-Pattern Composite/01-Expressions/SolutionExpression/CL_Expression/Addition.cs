using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public class Addition : BinaryOperator
    {
        public Addition(Expression leftMember, Expression rightMember) : base(leftMember, rightMember) { }

        public override int Evaluate()
        {
            return this.leftOperand.Evaluate() + this.rightOperand.Evaluate();
        }

        public override string ToString()
        {
            return this.leftOperand.ToString() + " + " + this.rightOperand.ToString();
        }
    }
}
