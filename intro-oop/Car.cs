namespace intro_oop;

internal class Car
{
    private readonly IEngine _engine; // Composition with polymorphism (Legos)

    public Car(IEngine engine) // Constructor injection
    {
        _engine = engine;
    }

    public void Start()
    {
        Console.WriteLine("Car is started.");
        _engine.Run();
    }
}