using CL_Robot.CommandesRobot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot
{
    public class Invocateur
    {
        private List<ICommande> historiqueCommandes;

        public Invocateur()
        {
            this.historiqueCommandes = new List<ICommande> { };
        }

        public void Executer(ICommande commande)
        {
            this.historiqueCommandes.Add(commande);
            commande.Executer();
        }

        public void Annuler()
        {
            ICommande commande = this.historiqueCommandes[this.historiqueCommandes.Count - 1];
            commande.Annuler();
            this.historiqueCommandes.Remove(commande);
        }
    }
}
