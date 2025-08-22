namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        //TODO: Uncomment the following lines and inject the dependencies
        // Camera camera = new Camera();
        // Battery battery = new Battery();

        var phone = new Smartphone(/*camera, battery*/);
        phone.TakePhoto();
        phone.Charge();
    }
}