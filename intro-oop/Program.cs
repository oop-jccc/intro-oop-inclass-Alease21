namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        IEngine engine = new Engine();
        IEngine safetyEngine = new SafetyCheckEngineDecorator(engine);
        Car myCar = new Car(safetyEngine);
        myCar.Start();
    }
}