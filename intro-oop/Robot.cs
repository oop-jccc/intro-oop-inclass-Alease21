namespace intro_oop;

public class Robot : INameable
{
    private readonly string _name;

    public Robot(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}