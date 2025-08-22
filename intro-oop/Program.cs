namespace intro_oop;

internal static class Program
{
    public static void Main()
    {
        INotifier notifier = new EmailNotifier();
        notifier.Notify("123");
    }
}