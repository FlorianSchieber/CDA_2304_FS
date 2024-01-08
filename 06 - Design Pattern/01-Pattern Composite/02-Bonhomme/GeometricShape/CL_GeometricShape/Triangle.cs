using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public class Triangle : GeometricShape
    {
        private Coordinates[] secondCoordinates;

        public Triangle() : base()
        {
            this.secondCoordinates = new Coordinates[2] { new Coordinates(0, 0), new Coordinates(0, 0) };
        }
        
        public Triangle(Coordinates coordinates1, Coordinates coordinates2, Coordinates coordinates3) : base(coordinates1)
        {
            this.secondCoordinates = new Coordinates[2] { coordinates2 - coordinates1, coordinates3 - coordinates1 };
        }
    }
}
