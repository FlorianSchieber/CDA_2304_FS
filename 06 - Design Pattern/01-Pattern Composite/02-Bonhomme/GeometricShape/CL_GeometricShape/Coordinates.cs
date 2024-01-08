using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public class Coordinates
    {
        private double x;
        private double y;

        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinates(Coordinates coordinates)
        {
            this.x = coordinates.X;
            this.y = coordinates.Y;
        }

        public double X { get { return this.x; } }
        public double Y { get { return this.y; } }

        public static Coordinates operator +(Coordinates a, Coordinates b)
        {
            double newX = a.X + b.X;
            double newY = a.Y + b.Y;

            return new Coordinates(newX, newY);
        }

        public static Coordinates operator -(Coordinates coordinates)
        {
            return new Coordinates(-coordinates.X, -coordinates.Y);
        }

        public static Coordinates operator -(Coordinates a, Coordinates b)
        {
            return a + (-b);
        }

        public override string ToString()
        {
            if (this is not null)
            {
                return "(" + this.x.ToString() + ", " +  this.y.ToString() +")";
            }
            else
            {
                return "No coordinates";
            }
            
        }
    }
}
