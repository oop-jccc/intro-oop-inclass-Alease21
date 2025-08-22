namespace intro_oop;

public class Triangle : Shape
{
    private readonly double _base;
    private readonly double _height;

    public Triangle(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public override double Area()
    {
        return _base * _height / 2;
    }
}
