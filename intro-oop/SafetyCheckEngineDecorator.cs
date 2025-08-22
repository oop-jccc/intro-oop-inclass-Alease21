namespace intro_oop;

internal class SafetyCheckEngineDecorator : IEngine
{
    private readonly IEngine _decoratedEngine;

    public SafetyCheckEngineDecorator(IEngine decoratedEngine)
    {
        _decoratedEngine = decoratedEngine;
    }

    public void Run()
    {
        Console.WriteLine("Performing safety check...");
        if (IsSafeToRun())
        {
            _decoratedEngine.Run();
        }
        else
        {
            Console.WriteLine("Safety check failed. Engine not started.");
        }
    }

    private bool IsSafeToRun()
    {
        // Safety checks logic here.
        // For demo purposes, returning true.
        return true;
    }
}