using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_JeuDeLaGuerre
{
    public abstract class Personnage
    {
        private string pseudo;

        public Personnage(string _pseudo)
        {
            this.pseudo = _pseudo;
        }

        public void SeDeplacer()
        { }

        public abstract bool EstSoigne();
    }
}
