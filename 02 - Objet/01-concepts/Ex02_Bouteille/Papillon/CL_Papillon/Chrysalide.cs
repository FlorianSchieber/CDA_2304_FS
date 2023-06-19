using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Papillon
{
    public class Chrysalide : StadeLepidoptere
    {
        public Chrysalide()
        {

        }

        public override StadeLepidoptere SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
