namespace intro_oop;

public class NotificationService
{
    private readonly INotifier _emailNotifier;

    public NotificationService(INotifier emailNotifier)
    {
        _emailNotifier = emailNotifier;
    }

    public void NotifyUser(string userId)
    {
        _emailNotifier.Notify(userId);
    }
}