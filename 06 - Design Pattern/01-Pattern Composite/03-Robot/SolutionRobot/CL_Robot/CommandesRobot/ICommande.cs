using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot.CommandesRobot
{
    public interface ICommande
    {
        public abstract void Executer();

        public abstract void Annuler();
    }
}
