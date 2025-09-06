namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var circle = new Circle(1.0);
        var triangle = new Triangle(1.0, 2.0);
        var square = new Square(2.0f);

        var shapes = new List<Shape>
        {
            circle,
            triangle,
            square
        };
        var names = new List<INameable>
        {
            circle,
            triangle,
            new Dog(),
            square
        };

        PrintArea(shapes);
        PrintName(names);
    }

    private static void PrintArea(IEnumerable<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetName()} = {shape.Area()}");
        }
    }

    private static void PrintName(IEnumerable<INameable> nameables)
    {
        foreach (var nameable in nameables)
        {
            Console.WriteLine(nameable.GetName());
        }
    }
}