using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot.CommandesRobot
{
    public class CommandeEteindre : CommandeRobot
    {
        public CommandeEteindre(Robot robotReceveur) : base(robotReceveur) { }

        public override void Executer()
        {
            robotReceveur.Eteindre();
        }

        public override void Annuler()
        {
            robotReceveur.Allumer();
        }
    }
}
