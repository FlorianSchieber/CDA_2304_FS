using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public class Circle : GeometricShape
    {
        private double radius;

        public Circle() : base()
        {
            this.radius = 0;
        }

        public Circle(Coordinates coordinates, double radius) : base(coordinates)
        {
            this.radius = radius;
        }

        public double Radius { get { return this.radius; } }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
