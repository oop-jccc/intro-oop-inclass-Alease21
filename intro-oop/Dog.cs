namespace intro_oop;

public class Dog : INameable
{
    public string GetName() // note: no override keyword
    {
        return "Samson";
    }
}
