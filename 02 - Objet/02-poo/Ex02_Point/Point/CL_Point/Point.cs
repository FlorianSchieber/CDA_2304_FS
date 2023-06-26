using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CL_Point
{
    public class Point
    {
        private double x;
        private double y;

        public Point(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Point()
            : this(0, 0)
        {}

        public double[] GetCoordinates()
        {
            return new double[] { this.x, this.y };
        }

        public void SetAt(double newX, double newY)
        {
            this.x = newX;
            this.y = newY;
        }

        public Point SymmetricAboutXAxis()
        {
            return new Point(this.x, -this.y);
        }

        public Point SymmetricAboutYAxis()
        {
            return new Point(-this.x, this.y);
        }

        public Point SymmetricAboutOrigin()
        {
            return new Point(-this.x, -this.y);
        }

        public void PermutateCoordinate()
        {
            this.SetAt(this.y, this.x);
        }

        public override string ToString()
        {
            return "(" + this.x + "; " + this.y + ")";
        }

    }
}
