using CL_GeometricShape;

internal class Program
{
    private static void Main(string[] args)
    {
        Group rootGroup = new Group(new Coordinates(0, 1));

        Rectangle myRectangle = new Rectangle(new Coordinates(1, 2), 5, 6);

        rootGroup.Add(myRectangle);

        Triangle myTriangle = new Triangle(new Coordinates(3, 5), new Coordinates(1, 2), new Coordinates(5, 7));

        rootGroup.Add(myTriangle);

        Console.WriteLine(myRectangle.Coordinates.ToString());
        Console.WriteLine(myRectangle.AbsoluteCoordinates(rootGroup).ToString());

        Console.WriteLine(myTriangle.Coordinates.ToString());
        Console.WriteLine(myTriangle.AbsoluteCoordinates(rootGroup).ToString());
    }
}