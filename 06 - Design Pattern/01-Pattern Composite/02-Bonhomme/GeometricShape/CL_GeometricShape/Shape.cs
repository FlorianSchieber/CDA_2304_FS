using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public abstract class Shape
    {
        private Coordinates coordinates;

        public Shape() : this(new Coordinates(0, 0)) { }

        public Shape(Coordinates coordinates)
        {
            this.coordinates = coordinates;
        }

        public Coordinates Coordinates { get { return this.coordinates; } }

        public void MoveTo(Coordinates newCoordinates)
        {
            this.coordinates = newCoordinates;
        }

        public void Move(Coordinates coordinatesToAdd)
        {
            this.coordinates = this.coordinates + coordinatesToAdd;
        }

        public Coordinates? AbsoluteCoordinates(Shape referencial)
        {

            if (ReferenceEquals(this, referencial))
            {
                return this.coordinates;
            }
            else if (referencial is Group)
            {
                bool found = false;
                int index = 0;
                Coordinates? tempCoordinates = null;
                Group groupReferencial = (Group)referencial;

                while (!found && index < groupReferencial.ChildShapes.Count)
                {
                    tempCoordinates = this.AbsoluteCoordinates(groupReferencial.ChildShapes[index]);
                    found = tempCoordinates != null;
                    index++;
                }

                if (found)
                {
                    return  tempCoordinates + referencial.Coordinates;
                }
            }

            return null;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
