namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var myEngine = new Engine();
        var myCar = new Car(myEngine);
        myCar.Start();
    }
}