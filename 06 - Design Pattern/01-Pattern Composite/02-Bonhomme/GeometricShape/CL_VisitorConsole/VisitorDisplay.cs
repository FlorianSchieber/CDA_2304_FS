using CL_GeometricShape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CL_VisitorConsole
{
    public class VisitorDisplay : CL_GeometricShape.IVisitor
    {
        public void Visit(Group group)
        {
            Console.WriteLine(this.Talk("un groupe", group.Coordinates.ToString()));
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine(this.Talk("un cercle", circle.Coordinates.ToString()) + " de rayon " + circle.Radius);
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine(this.Talk("un rectangle", rectangle.Coordinates.ToString()) + " de largeur " + rectangle.Width + " et de hauteur " + rectangle.Height);
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine(this.Talk("un triangle", triangle.Coordinates.ToString()));
        }

        private string Talk(string shape, string coordinates)
        {
            return "Je suis " + shape + " situé à " + coordinates;
        }
    }
}
