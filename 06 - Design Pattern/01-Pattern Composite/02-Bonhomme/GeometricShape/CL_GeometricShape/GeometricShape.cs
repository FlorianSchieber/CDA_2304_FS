using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public abstract class GeometricShape : Shape
    {
        public GeometricShape() : base() { }

        public GeometricShape(Coordinates coordinates) : base(coordinates) { }
    }
}
