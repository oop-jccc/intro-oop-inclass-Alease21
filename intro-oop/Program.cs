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

public class EBook
{
    private readonly Book _book = new();

    public void Read()
    {
        _book.Read();
    }

    public void Download()
    {
        Console.WriteLine("Downloading...");
    }
}