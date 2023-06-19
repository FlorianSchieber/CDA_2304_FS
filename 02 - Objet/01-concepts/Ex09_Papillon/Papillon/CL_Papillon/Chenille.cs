using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Papillon
{
    public class Chenille : StadeLepidoptere
    {
        public Chenille()
        {

        }

        public override StadeLepidoptere SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
