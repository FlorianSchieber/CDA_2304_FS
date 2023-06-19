using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Papillon
{
    public class Papillon : StadeLepidoptere
    {
        public Papillon()
        {

        }

        public override StadeLepidoptere SeMetamorphoser()
        {
            return this;
        }
    }
}
