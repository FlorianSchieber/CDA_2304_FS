using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public class Group : Shape
    {
        private List<Shape> childShapes;

        public Group() : base()
        {
            this.childShapes = new List<Shape> { };
        }

        public Group(Coordinates coordinates) : base(coordinates)
        {
            this.childShapes = new List<Shape> { };
        }

        public List<Shape> ChildShapes { get { return this.childShapes; } }

        public void Add(Shape shapeToAdd)
        {
            this.childShapes.Add(shapeToAdd);
        }

        public void Remove(Shape shapeToRemove)
        {
            this.childShapes.Remove(shapeToRemove);
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (Shape shape in this.childShapes)
            {
                shape.Accept(visitor);
            }
        }
    }
}
