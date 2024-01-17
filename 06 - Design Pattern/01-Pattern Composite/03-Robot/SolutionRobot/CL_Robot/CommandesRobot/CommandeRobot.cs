using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot.CommandesRobot
{
    public abstract class CommandeRobot : ICommande
    {
        protected Robot robotReceveur;

        public CommandeRobot(Robot robotReceveur)
        {
            this.robotReceveur = robotReceveur;
        }

        public abstract void Executer();

        public abstract void Annuler();
    }
}
