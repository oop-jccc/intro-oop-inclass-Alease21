namespace intro_oop;

public class Square : Shape
{
    private readonly double _side;
    public Square(double side)
    {
        _side = side;
    }
    public override double Area()
    {
        return _side * _side;
    }
}