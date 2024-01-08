using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public class Substraction : BinaryOperator
    {
        public Substraction(Expression leftMember, Expression rightMember) : base(leftMember, rightMember) { }

        public override int Evaluate()
        {
            return this.leftOperand.Evaluate() - this.rightOperand.Evaluate();
        }

        public override string ToString()
        {
            if (this.rightOperand is Number)
            {
                return this.leftOperand.ToString() + " - " + this.rightOperand.ToString();
            }
            else
            {
                return this.leftOperand.ToString() + " - (" + this.rightOperand.ToString() + ")";
            }
            
        }
    }
}
