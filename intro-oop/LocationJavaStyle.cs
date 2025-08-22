namespace intro_oop;

public class LocationJavaStyle
{
    private decimal _x;
    private double _y;

    public double GetX()
    {
        return (double)_x;
    }

    public double GetY()
    {
        return _y;
    }

    public void SetX(double x)
    {
        _x = (decimal)x;
    }

    public void SetY(double y)
    {
        if(y < 10000) throw new Exception("Y is too big");
        _y = y;
    }
}