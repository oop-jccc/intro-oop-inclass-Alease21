namespace intro_oop;

internal class Program
{
    public static void Main()
    {
        var circle = new Circle(1.0);
        // var triangle = new Triangle(1.0, 2.0);
        // var dog = new Dog();
        // var square = new Square(1.0);
        var location1 = new LocationJavaStyle();
        location1.SetX(0);
        location1.SetY(0);

        var location2 = new LocationManualProps();
        location2.X = 0;
        location2.Y = 0;

        var location3 = new LocationManualProps {X = 0, Y = 0};


        Console.WriteLine(circle.Area());
    }
}
