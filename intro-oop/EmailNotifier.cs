namespace intro_oop;

public class EmailNotifier : INotifier
{
    public void Notify(string userID)
    {
        Console.WriteLine($"Sending email notification to user with ID: {userID}");
    }
}