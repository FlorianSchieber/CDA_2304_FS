using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public class Rectangle : GeometricShape
    {
        private double height;
        private double width;

        public Rectangle() : base()
        {
            this.height = 0;
            this.width = 0;
        }

        public Rectangle(Coordinates coordinates, double height, double width) : base(coordinates)
        {
            this.height = height;
            this.width = width;
        }
    }
}
