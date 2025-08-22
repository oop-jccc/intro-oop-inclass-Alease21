namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var notificationService = new NotificationService();
        notificationService.NotifyUser("User123");
    }
}