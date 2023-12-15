using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_JeuDeLaGuerre
{
    internal class Arme
    {
        private string nom;
        private readonly uint puissance;

        public Arme(string _nom, uint _puissance)
        {
            this.nom = _nom;
            this.puissance = _puissance;
        }

        public uint accPuissance()
        {
            return this.puissance;
        }
    }
}
