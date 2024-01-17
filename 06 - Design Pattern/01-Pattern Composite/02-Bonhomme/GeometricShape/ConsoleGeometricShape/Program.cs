using CL_GeometricShape;
using CL_VisitorConsole;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Group rootGroup = new Group(new Coordinates(0, 1));

        Rectangle myRectangle = new Rectangle(new Coordinates(1, 2), 5, 6);
        rootGroup.Add(myRectangle);

        Triangle myTriangle = new Triangle(new Coordinates(3, 5), new Coordinates(1, 2), new Coordinates(5, 7));
        rootGroup.Add(myTriangle);

        Group myGroup = new Group(new Coordinates(12, 7));
        rootGroup.Add(myGroup);

        Circle myCircle = new Circle(new Coordinates(3, 4), 5.6);
        myGroup.Add(myCircle);

        rootGroup.Accept(new VisitorDisplay());
    }
}