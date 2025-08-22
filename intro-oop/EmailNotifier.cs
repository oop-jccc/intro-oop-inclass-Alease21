namespace intro_oop;

public class EmailNotifier : INotifier
{
    public void Notify(string userId)
    {
        Console.WriteLine($"Email notification sent to user: {userId}");
    }
}