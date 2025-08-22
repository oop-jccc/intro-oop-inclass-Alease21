// See https://aka.ms/new-console-template for more information

namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var circle = new Circle(1.0);
        var triangle = new Triangle(1.0, 2.0);
        var dog = new Dog();
        var square = new Square(1.0);

        var shapes = new Shape[] { circle, triangle, square };
        var names = new INameable[] { circle, triangle, dog, square };

        PrintArea(shapes);
        PrintName(names);
    }

    private static void PrintArea(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetName()} = {shape.Area()}");
        }
    }

    private static void PrintName(INameable[] nameables)
    {
        foreach (var nameable in nameables)
        {
            Console.WriteLine(nameable.GetName());
        }
    }
}
