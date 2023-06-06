using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    internal class Bouteille
    {
        private double capaciteEnL;
        private double contenuEnL;
        private bool estOuverte;
        private string typeContenu;

        public bool Fermer();
        public bool Ouvrir();
        public bool Remplir();
        public bool Remplir(double volumeAjouteEnL);
        public bool Vider();
        public bool Vider(double volumeRetireEnL);
    }
}
