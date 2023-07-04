using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Bouteille
{
    public class Bouteille
    {
        private const double CAPACITE_PAR_DEFAUT = 1;

        private readonly double capaciteEnL;
        private double contenuEnL;
        private bool estOuverte;
        private string nom;

        public Bouteille(double _capaciteEnL, string _nom)
        {
            this.capaciteEnL = _capaciteEnL;
            this.contenuEnL = _capaciteEnL;
            this.estOuverte = false;
            this.nom = _nom;
        }

        public Bouteille()
        {
            this.capaciteEnL = CAPACITE_PAR_DEFAUT;
            this.contenuEnL = CAPACITE_PAR_DEFAUT;
            this.estOuverte = false;
            this.nom = "";
        }

        public bool Fermer()
        {
            if (this.estOuverte)
            {
                this.estOuverte = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ouvrir()
        {
            if (!this.estOuverte)
            {
                this.estOuverte = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remplir()
        {
            if (this.estOuverte)
            {
                if (this.contenuEnL < this.capaciteEnL)
                {
                    this.contenuEnL = this.capaciteEnL;
                    return true;
                }
            }
            return false;
        }

        public bool Remplir(double volumeAjouteEnL)
        {
            if (this.estOuverte)
            {
                if (volumeAjouteEnL > 0)
                {
                    double nouveauContenuEnL = this.contenuEnL + volumeAjouteEnL;

                    if (nouveauContenuEnL <= this.capaciteEnL)
                    {
                        this.contenuEnL = nouveauContenuEnL;
                        return true;
                    }
                }
            }
            return false;
            
        }

        public bool Vider()
        {
            if (this.estOuverte)
            {
                if (this.contenuEnL > 0)
                {
                    this.contenuEnL = 0;
                    return true;
                }
            }
            return false;
        }

        public bool Vider(double volumeRetireEnL)
        {
            if (this.estOuverte)
            {
                if (volumeRetireEnL > 0)
                {
                    double nouveauContenuEnL = this.contenuEnL - volumeRetireEnL;

                    if (nouveauContenuEnL >= 0)
                    {
                        this.contenuEnL = nouveauContenuEnL;
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return this.nom +
                ", Capacité : " + this.capaciteEnL +
                ", Contenu : " + this.contenuEnL +
                ", " + (this.estOuverte ? "Ouverte" : "Fermée");
        }
    }
}
