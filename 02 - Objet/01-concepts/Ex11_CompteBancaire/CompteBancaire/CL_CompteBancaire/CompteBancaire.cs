using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CompteBancaire
{
    public class CompteBancaire
    {
        private uint id;
        private string nomProprietaire;
        private int soldeEnCentimes;
        private int decouvertAutoriseEnCentimes;

        private static double EnDevise(int centimes)
        {
            return centimes / 100d;
        }

        private static int EnCentimes(double devise)
        {
            return (int) Math.Floor(devise);
        }

        public CompteBancaire(uint _id)
        {
            this.id = _id;
            this.nomProprietaire = "";
            this.soldeEnCentimes = 0;
            this.decouvertAutoriseEnCentimes = 0;
        }

        public CompteBancaire(uint _id, string _nomProprietaire, int _soldeEnCentimes, int _decouvertAutoriseEnCentimes)
        {
            if (_decouvertAutoriseEnCentimes <= 0)
            {
                this.id = _id;
                this.nomProprietaire = _nomProprietaire;
                this.soldeEnCentimes = _soldeEnCentimes;
                this.decouvertAutoriseEnCentimes = _decouvertAutoriseEnCentimes;
            }
            else
            {
                throw new Exception("Le découvert autorisé doit être négatif ou nul");
            }
        }

        public string DonneInformations()
        {
            return "ID : " + this.id +
                " | Propriétaire : " + this.nomProprietaire +
                " | Solde : " + this.soldeEnCentimes + " cents." +
                " | Découvert autorisé : " + this.decouvertAutoriseEnCentimes;
        }

        public override string ToString()
        {
            return this.DonneInformations();
        }
    }
}
