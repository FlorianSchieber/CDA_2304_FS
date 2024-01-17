using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot.CommandesRobot
{
    public class CommandeAvancer : CommandeRobot
    {
        private double distance;

        public CommandeAvancer(Robot robotReceveur, double distance) : base(robotReceveur)
        {
            this.distance = distance;
        }

        public override void Executer()
        {
            robotReceveur.Avancer(distance);
        }

        public override void Annuler()
        {
            robotReceveur.Avancer(-distance);
        }
    }
}
