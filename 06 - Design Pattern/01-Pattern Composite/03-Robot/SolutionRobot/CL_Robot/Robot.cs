using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Robot
{
    public class Robot
    {
        private bool estAllume;
        private double positionX;
        private double positionY;
        private double angleEnRadians;

        public Robot() : this(false, 0, 0, 0) { }

        public Robot(bool estAllume, double positionX, double positionY, double angleEnRadians)
        {
            this.estAllume = estAllume;
            this.positionX = positionX;
            this.positionY = positionY;
            this.angleEnRadians = angleEnRadians;
        }

        public void Allumer()
        {
            if (!this.estAllume)
            {
                this.estAllume = true;
            }
        }

        public void Eteindre()
        {
            if (this.estAllume)
            {
                this.estAllume = false;
            }
        }

        public void Avancer(double distance)
        {
            if (this.estAllume)
            {
                this.positionX += distance * Math.Cos(this.angleEnRadians);
                this.positionY += distance * Math.Sin(this.angleEnRadians);
            }
        }

        public void Tourner(double angleEnRadians)
        {
            if (this.estAllume)
            {
                this.angleEnRadians += angleEnRadians;
            }
        }

        public string ToString()
        {
            return "(" + this.positionX + " ; " + this.positionY + ")";
        }
    }
}
