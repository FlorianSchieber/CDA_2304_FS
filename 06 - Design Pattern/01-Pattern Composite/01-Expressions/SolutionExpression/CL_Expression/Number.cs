using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public class Number : Expression
    {
        private int value;

        public Number(int value)
        {
            this.value = value;
        }

        public override int Evaluate()
        {
            return this.value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
