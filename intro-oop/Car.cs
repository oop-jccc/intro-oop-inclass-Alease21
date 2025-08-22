namespace intro_oop;

internal class Car
{
    private readonly Engine _engine; // Composition without polymorphism (Legos with glue)

    public Car(Engine engine) // Constructor injection
    {
        _engine = engine;
    }

    public void Start()
    {
        Console.WriteLine("Car is started.");
        _engine.Run();
    }
}