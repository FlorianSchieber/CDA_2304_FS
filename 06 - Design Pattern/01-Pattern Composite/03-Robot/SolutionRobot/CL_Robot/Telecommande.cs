using CL_Robot.CommandesRobot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot
{
    public class Telecommande
    {

        private Robot robotReceveur;
        private Invoqueur invoqueur;

        public Telecommande(Robot robotReceveur)
        {
            this.robotReceveur = robotReceveur;
            this.invoqueur = new Invoqueur(robotReceveur);
        }

        public void BoutonAllumer()
        {
            this.invoqueur.Executer(new CommandeAllumer(this.robotReceveur));
        }

        public void BoutonEteindre()
        {
            this.invoqueur.Executer(new CommandeEteindre(this.robotReceveur));
        }

        public void BoutonAvancer(double distance)
        {
            this.invoqueur.Executer(new CommandeAvancer(this.robotReceveur, distance));
        }

        public void BoutonTourner(double angleEnRadians)
        {
            this.invoqueur.Executer(new CommandeTourner(this.robotReceveur, angleEnRadians));

        }
    }
}
