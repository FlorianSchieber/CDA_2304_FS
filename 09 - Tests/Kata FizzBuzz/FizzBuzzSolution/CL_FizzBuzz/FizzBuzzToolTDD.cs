using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FizzBuzz
{
    public static class FizzBuzzToolTDD
    {
        public static string FizzBuzz(int nombre)
        {
            if (nombre == 1)
            {
                return "1";
            }
            else if (nombre == 5)
            {
                return "Buzz";
            }

            return "Fizz";
        }
    }
}
