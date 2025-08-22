namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var circle = new Circle(1.0);
        var triangle = new Triangle(1.0, 2.0);

        var shapes = new Shape[] { circle, triangle };

        PrintArea(shapes);
    }
    
    private static void PrintArea(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Area());
        }
    }
}