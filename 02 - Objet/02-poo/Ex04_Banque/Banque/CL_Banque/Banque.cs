using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CL_Banque
{
    public class Banque
    {
        private string nom;
        private string ville;

        private List<CompteBancaire> mesComptes;

        public Banque(string _nom, string _ville)
        {
            this.nom = _nom;
            this.ville = _ville;
            this.mesComptes = new List<CompteBancaire> {};
        }

        private bool PossedeId(uint idRecherche)
        {
            int indiceCompte = 0;
            bool idSimilaire = false;

            while (indiceCompte < this.mesComptes.Count() && !idSimilaire)
            {
                if (idRecherche == this.mesComptes[indiceCompte].DonneId())
                {
                    idSimilaire = true;
                }
                indiceCompte++;
            }

            return idSimilaire;
        }

        private bool PasDeCompte()
        {
            return this.mesComptes.Count() == 0;
        }

        public bool AjouterCompte(uint _id, string _nomProprietaire, string _devise, int _soldeEnDevise, int _decouvertAutoriseEnDevise)
        {
            CompteBancaire compteAAjouter = new CompteBancaire(_id, _nomProprietaire, _devise, _soldeEnDevise, _decouvertAutoriseEnDevise);

            return AjouterCompte(compteAAjouter);
        }

        private bool AjouterCompte(CompteBancaire compteAAjouter)
        {
            if (!this.PossedeId(compteAAjouter.DonneId()))
            {
                this.mesComptes.Add(compteAAjouter);
                return true;
            }

            return false;
        }

        public void CompteSuperieur()
        {
            if (!this.PasDeCompte())
            {
                CompteBancaire compteMax = this.mesComptes[0];
                
                for (int indiceCompte = 1; indiceCompte < this.mesComptes.Count(); indiceCompte++)
                {
                    if (mesComptes[indiceCompte].EstSuperieurA(compteMax))
                    {
                        compteMax = mesComptes[indiceCompte];
                    }
                }

                Console.WriteLine(compteMax);
            }
            else
            {
                Console.WriteLine(this.nom + "n'a pas de compte");
            }
        }

        public CompteBancaire? DonneCompte(uint idRecherche)
        {
            bool aTrouve = false;
            int indiceCompte = 0;
            CompteBancaire compteRecherche = null;

            while (indiceCompte < this.mesComptes.Count() && !aTrouve)
            {
                if (idRecherche == this.mesComptes[indiceCompte].DonneId())
                {
                    compteRecherche = this.mesComptes[indiceCompte];
                }
                indiceCompte++;
            }

            return compteRecherche;
        }

        public bool Transferer(uint idCompteDebiteur, uint idCompteCrediteur, uint montantEnDevise)
        {
            CompteBancaire? compteDebiteur = this.DonneCompte(idCompteDebiteur);
            CompteBancaire? compteCrediteur = this.DonneCompte(idCompteCrediteur);

            if (compteDebiteur != null && compteCrediteur != null)
            {
                return compteDebiteur.TransfererVers(compteCrediteur, montantEnDevise);
            }

            return false;
        }

        public override string ToString()
        {
            string resultat = "Nom Banque : " + this.nom +
                "\nVille Banque : " + this.ville + "\n";

            for (int indiceCompte = 0; indiceCompte < this.mesComptes.Count(); indiceCompte++)
            {
                resultat += this.mesComptes[indiceCompte] + "\n";
            }

            return resultat;
        }
    }
}
