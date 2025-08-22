namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var myEBook = new EBook();
        myEBook.Download();
        myEBook.Read();
    }
}

public class Book
{
    public void Read()
    {
        Console.WriteLine("Reading...");
    }
}

public class EBook : Book
{
    public void Download()
    {
        Console.WriteLine("Downloading...");
    }
}