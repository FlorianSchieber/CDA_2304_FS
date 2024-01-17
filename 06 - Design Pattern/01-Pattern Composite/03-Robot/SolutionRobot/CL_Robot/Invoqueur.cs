using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Robot.CommandesRobot;

namespace CL_Robot
{
    public class Invoqueur
    {
        private Robot robotReceveur;
        private List<ICommande> historiqueCommandes;

        public Invoqueur(Robot robotReceveur)
        {
            this.robotReceveur = robotReceveur;
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
