namespace intro_oop;

public class NotificationService
{
    private readonly EmailNotifier _emailNotifier = new();

    public void NotifyUser(string userId)
    {
        _emailNotifier.SendEmail(userId);
    }
}