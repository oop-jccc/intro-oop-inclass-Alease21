namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var emailNotifier = new EmailNotifier();
        var notificationService = new NotificationService(emailNotifier);

        notificationService.NotifyUser("123");
    }
}