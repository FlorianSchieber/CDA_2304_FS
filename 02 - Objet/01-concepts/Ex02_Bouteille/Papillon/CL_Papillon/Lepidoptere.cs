using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Papillon
{
    public class Lepidoptere
    {
        private StadeLepidoptere sonStade;

        public Lepidoptere()
        {
            this.sonStade = new Chenille();
        }

        public bool SeMetamorphoser()
        {
            this.sonStade = this.sonStade.SeMetamorphoser();
            return true;
        }
    }
}
