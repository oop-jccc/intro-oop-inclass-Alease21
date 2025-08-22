namespace intro_oop;

public abstract class Shape : INameable
{
    public abstract double Area();
    public Location? Location { get; set; }
    public string GetName() // note: no override keyword
    {
        return GetType().Name;
    }
}
