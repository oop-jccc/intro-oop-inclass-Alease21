using intro_oop;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(new Circle(1.0).Area());

        var location1 = new Location { X = 1.0, Y = 2.0 };
        var location2 = new Location { X = 1.0, Y = 2.0 };
        Console.WriteLine(location1.Equals(location2));
    }
}