using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_GeometricShape
{
    public interface IVisitor
    {
        public abstract void Visit(Group group);
        public abstract void Visit(Circle circle);
        public abstract void Visit(Rectangle rectangle);
        public abstract void Visit(Triangle triangle);
    }
}
