namespace intro_oop;

public class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void NotifyUser(string userId)
    {
        _notifier.Notify(userId);
    }
}