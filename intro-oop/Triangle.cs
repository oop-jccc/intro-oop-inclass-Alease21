namespace intro_oop;

public class Triangle
{
    private readonly double _base;
    private readonly double _height;

    public Triangle(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public double GetArea()
    {
        return _base * _height / 2;
    }
}
