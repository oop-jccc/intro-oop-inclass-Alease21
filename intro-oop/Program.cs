namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        IEngine engine = new Engine();
        IEngine safetyEngine = new SafetyCheckEngineDecorator(engine);
        IEngine performanceEngine = new PerformanceTuningEngineDecorator(safetyEngine);
        
        Car myCar = new Car(performanceEngine);
        myCar.Start();
    }
}