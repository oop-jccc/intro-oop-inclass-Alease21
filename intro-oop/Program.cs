// See https://aka.ms/new-console-template for more information

namespace intro_oop;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(new Circle(1.0).Area());

        var location1 = new Location { X = 1.0, Y = 2.0 };
        var location2 = new Location { X = 1.0, Y = 2.0 };
        Console.WriteLine(location1.Equals(location2));
    }
}
