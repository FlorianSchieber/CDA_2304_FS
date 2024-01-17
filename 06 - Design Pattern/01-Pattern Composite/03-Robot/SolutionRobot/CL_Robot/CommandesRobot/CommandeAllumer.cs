using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot.CommandesRobot
{
    public class CommandeAllumer : CommandeRobot
    {
        public CommandeAllumer(Robot robotReceveur) : base(robotReceveur) { }

        public override void Executer()
        {
            robotReceveur.Allumer();
        }

        public override void Annuler()
        {
            robotReceveur.Eteindre();
        }
    }
}
