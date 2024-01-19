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
        private Invocateur invocateur;

        public Telecommande(Robot robotReceveur)
        {
            this.robotReceveur = robotReceveur;
            this.invocateur = new Invocateur(robotReceveur);
        }

        public void BoutonAllumer()
        {
            this.invocateur.Executer(new CommandeAllumer(this.robotReceveur));
        }

        public void BoutonEteindre()
        {
            this.invocateur.Executer(new CommandeEteindre(this.robotReceveur));
        }

        public void BoutonAvancer(double distance)
        {
            this.invocateur.Executer(new CommandeAvancer(this.robotReceveur, distance));
        }

        public void BoutonTourner(double angleEnRadians)
        {
            this.invocateur.Executer(new CommandeTourner(this.robotReceveur, angleEnRadians));

        }
    }
}
