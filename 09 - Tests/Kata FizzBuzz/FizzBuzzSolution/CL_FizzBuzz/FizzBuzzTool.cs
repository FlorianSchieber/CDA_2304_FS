using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_FizzBuzz
{
    public static class FizzBuzzTool
    {
        public static string FizzBuzz(int nombre)
        {
            
            if (nombre % 3 == 0 && nombre % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (nombre % 3 == 0)
            {
                return "Fizz";
            }
            else if (nombre % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return nombre.ToString();
            }
            
        }
    }
}
