using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_JeuDeLaGuerre
{
    public class Guerrier : Personnage
    {
        private uint vies;

        private List<Arme> sesArmes; 

        public Guerrier(string _pseudo, uint _vies)
            : base(_pseudo)
        {
            this.vies = _vies;
            this.sesArmes = new List<Arme> {};
        }

        public bool EstVivant()
        {
            return this.vies > 0;
        }

        public bool AjouterArme(string nomArme, uint puissanceArme)
        {
            if (this.EstVivant())
            {
                this.sesArmes.Add(new Arme(nomArme, puissanceArme));
                return true;
            }

            return false;
            
        }

        public bool RetirerArme(int indiceArmeARetirer)
        {
            if (indiceArmeARetirer >= 0 && indiceArmeARetirer < sesArmes.Count())
            {
                this.sesArmes.RemoveAt(indiceArmeARetirer);
                return true;
            }

            return false;
        }

        public uint PuissanceTotale()
        {
            uint sommePuissanceArmes = 0;

            foreach (Arme arme in this.sesArmes)
            {
                sommePuissanceArmes += arme.accPuissance();
            }

            return sommePuissanceArmes;
        }

        public bool GagnerUneVie()
        {
            if (this.EstVivant())
            {
                this.vies++;
                return true;
            }

            return false;
        }

        public bool PerdreUneVie()
        {
            if (this.EstVivant())
            {
                this.vies--;
                return true;
            }

            return false;
        }

        public bool Attaquer(List<Guerrier> ennemis)
        {
            if (this.EstVivant())                                       // Notre guerrier doit être vivant pour combattre
            {
                uint puissanceEnnemie = 0;

                foreach (Guerrier ennemi in ennemis)                    // Pour chaque ennemi vivant :
                {
                    if (ennemi.EstVivant())
                    {
                        puissanceEnnemie += ennemi.PuissanceTotale();   // On calcule leur puissance cumulée
                    }
                }

                if (this.PuissanceTotale() > puissanceEnnemie)          // Si notre guerrier est strictement plus fort :
                {
                    foreach (Guerrier ennemi in ennemis)
                    {
                        ennemi.PerdreUneVie();                          // Chaque ennemi perd une vie
                       
                    }
                    
                    return true;
                }
                else                                                    // Sinon :
                {
                    this.PerdreUneVie();                                // Notre guerrier perd une vie
                }
            }

            return false;
        }

        public override bool EstSoigne()
        {
            if (this.EstVivant())
            {
                this.GagnerUneVie();
                return true;
            }

            return false;
        }
    }
}
