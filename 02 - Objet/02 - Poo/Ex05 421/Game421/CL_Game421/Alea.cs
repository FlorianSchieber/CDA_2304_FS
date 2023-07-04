using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Game421
{
    internal class Alea : Random
    {
        private static Alea? myAlea = null;

        private Alea()
        {}

        public static Alea Instance()
        {
            if (myAlea == null)
            {
                myAlea = new Alea();

            }
            return myAlea;
        }

        public int New(int valMin, int valMax)
        {
            return base.Next(valMin, valMax + 1);
        }
    }

}
