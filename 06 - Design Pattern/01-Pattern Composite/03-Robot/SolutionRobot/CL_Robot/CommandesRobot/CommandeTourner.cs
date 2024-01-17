using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot.CommandesRobot
{
    public class CommandeTourner : CommandeRobot
    {
        private double angleEnRadians;

        public CommandeTourner(Robot robotReceveur, double angleEnRadians) : base(robotReceveur)
        {
            this.angleEnRadians = angleEnRadians;
        }

        public override void Executer()
        {
            robotReceveur.Tourner(angleEnRadians);
        }

        public override void Annuler()
        {
            robotReceveur.Tourner(-angleEnRadians);
        }
    }
}
