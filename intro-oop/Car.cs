namespace intro_oop;

internal class Car
{
    private readonly Engine _engine = new(); // Composition without polymorphism (Legos with glue)

    public void Start()
    {
        Console.WriteLine("Car is started.");
        _engine.Run();
    }
}