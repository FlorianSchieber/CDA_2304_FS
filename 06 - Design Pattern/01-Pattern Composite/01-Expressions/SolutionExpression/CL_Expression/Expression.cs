using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public abstract class Expression
    {
        public abstract int Evaluate();
 
        public string Format()
        {
            return this.ToString() + " = " + this.Evaluate();
        }
    }
}
