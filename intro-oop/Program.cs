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
    Book book = new Book();

    public void Read()
    {
        book.Read();
    }
    
    public void Download()
    {
        Console.WriteLine("Downloading...");
    }
}