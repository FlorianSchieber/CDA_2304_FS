using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Papillon.Stades
{
    internal abstract class StadeLepidoptere
    {
        public abstract StadeLepidoptere SeMetamorphoser();

        public abstract void SeDeplacer();
    }
}
