using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_JeuDeLaGuerre
{
    public class Medecin : Personnage
    {
        public Medecin(string _pseudo)
            : base(_pseudo)
        { }

        public override bool EstSoigne()
        {
            return true;
        }

        public bool Soigner(Personnage personnageASoigner)
        {
            return personnageASoigner.EstSoigne();
        }
    }
}
