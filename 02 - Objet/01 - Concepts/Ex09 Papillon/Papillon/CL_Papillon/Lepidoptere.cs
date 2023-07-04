using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Papillon.Stades;

namespace CL_Papillon
{
    public class Lepidoptere
    {
        private StadeLepidoptere sonStade;

        public Lepidoptere()
        {
            this.sonStade = new Chenille();
        }

        public void SeMetamorphoser()
        {
            this.sonStade = this.sonStade.SeMetamorphoser();
        }

        public void SeDeplacer()
        {
            this.sonStade.SeDeplacer();
        }
    }
}
