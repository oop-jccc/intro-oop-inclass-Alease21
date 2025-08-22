```csharp
namespace intro_oop;

internal static class Program
{
    public static void Main()
    {
        INotifier notifier = new EmailNotifier();
        var decoratedNotifier = new LoggingNotifierDecorator(notifier);
        decoratedNotifier.Notify("123");
    }
}

public class LoggingNotifierDecorator : INotifier
{
    private readonly INotifier _notifier;

    public LoggingNotifierDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string userId)
    {
        _notifier.Notify(userId);
        Console.WriteLine($"Log: Notification has been sent to user: {userId}");
    }
}
```