namespace intro_oop;

internal class PerformanceTuningEngineDecorator : IEngine
{
    private readonly IEngine _decoratedEngine;

    public PerformanceTuningEngineDecorator(IEngine decoratedEngine)
    {
        _decoratedEngine = decoratedEngine;
    }

    public void Run()
    {
        Console.WriteLine("Applying performance tuning...");
        _decoratedEngine.Run();
    }
}