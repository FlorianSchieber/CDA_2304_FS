using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Banque
{
    public class CompteBancaire
    {
        private uint id;
        private string nomProprietaire;
        private string devise;
        private int soldeEnDevise;
        private int decouvertAutoriseEnDevise;

        public CompteBancaire(uint _id, string _nomProprietaire, string _devise, int _soldeEnDevise, int _decouvertAutoriseEnDevise)
        {
            if (_decouvertAutoriseEnDevise <= 0)
            {
                this.id = _id;
                this.nomProprietaire = _nomProprietaire;
                this.devise = _devise;
                this.soldeEnDevise = _soldeEnDevise;
                this.decouvertAutoriseEnDevise = _decouvertAutoriseEnDevise;
            }
            else
            {
                throw new Exception("Le découvert autorisé doit être négatif ou nul");
            }
        }

        public CompteBancaire(uint _id)
            : this(_id, "", "", 0, 0)
        {
        }

        public uint DonneId()
        {
            return this.id;
        }

        public void Crediter(uint montantEnDevise)
        {
            this.soldeEnDevise += (int)montantEnDevise;
        }

        public bool Debiter(uint montantEnDevise)
        {
            int nouveauSoldeEnDevise = this.soldeEnDevise - (int)montantEnDevise;

            if (nouveauSoldeEnDevise >= this.decouvertAutoriseEnDevise)
            {
                this.soldeEnDevise = nouveauSoldeEnDevise;
                return true;
            }

            return false;
        }

        public bool TransfererVers(CompteBancaire compteCrediteur, uint montantTransfereEnDevise)
        {
            if (this.Debiter(montantTransfereEnDevise))
            {
                compteCrediteur.Crediter(montantTransfereEnDevise);
                return true;
            }

            return false;
        }

        public bool EstSuperieurA(CompteBancaire compteAComparer)
        {
            return this.soldeEnDevise > compteAComparer.soldeEnDevise;
        }

        public string DonneInformations()
        {
            return "ID : " + this.id +
                " | Propriétaire : " + this.nomProprietaire +
                " | Solde : " + this.soldeEnDevise + " " + devise +
                " | Découvert autorisé : " + this.decouvertAutoriseEnDevise + " " + devise;
        }

        public override string ToString()
        {
            return this.DonneInformations();
        }
    }
}
