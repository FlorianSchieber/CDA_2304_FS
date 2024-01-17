using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public class Rectangle : GeometricShape
    {
        private double width;
        private double height;
        

        public Rectangle() : base()
        {
            this.width = 0;
            this.height = 0;
        }
        
        public Rectangle(Coordinates coordinates, double width, double height) : base(coordinates)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get { return this.width; } }
        public double Height { get { return this.height; } }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
