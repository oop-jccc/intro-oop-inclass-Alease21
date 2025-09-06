namespace intro_oop;

public class Square : Shape
{
    private float _sideLength;

    public Square(float sideLength)
    {
        _sideLength = sideLength;
    }

    public override float Area()
    {
        return _sideLength * _sideLength;
    }
}