using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Voiture
    {
        private const int NOMBRE_ROUES = 4;

        private string marque;
        Moteur sonMoteur;
        Roue[] sesRoues;

        public Voiture() : this("",
            new Moteur(),
            new Roue[]
            {
                new Roue(),
                new Roue(),
                new Roue(),
                new Roue()
            })
        {
        }

        public Voiture(string _marque, Moteur _sonMoteur, Roue[] _sesRoues)
        {
            if (_sesRoues.Count() == NOMBRE_ROUES)
            {
                this.marque = _marque;
                this.sonMoteur = new Moteur(_sonMoteur);
                this.sesRoues = new Roue[NOMBRE_ROUES];
                for (int i = 0; i < NOMBRE_ROUES; i++)
                {
                    this.sesRoues[i] = new Roue(_sesRoues[i]);
                }
            }
            else
            {
                throw new Exception("Une voiture doit avoir 4 roues");
            }
            
        }

        public bool Demarrer()
        {
            return this.sonMoteur.Demarrer();
        }

        public bool Avancer()
        {
            List<Roue> rouesAEntrainer = new List<Roue> { this.sesRoues[0], this.sesRoues[1] };
            return this.sonMoteur.EntrainerRoues(rouesAEntrainer);
        }

        public bool Freiner()
        {
            List<Roue> rouesAArreter = new List<Roue> { this.sesRoues[0], this.sesRoues[1] };
            return this.sonMoteur.ArreterRoues(rouesAArreter);
        }
    }
}
