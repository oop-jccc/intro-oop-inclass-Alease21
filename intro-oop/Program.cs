namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        IBattery battery = new Battery();
        IBattery overchargeProtectedBattery = new OverchargeProtectionDecorator(battery);

        var phone = new Smartphone(new Camera(), overchargeProtectedBattery);
        for (var i = 0; i < 10; i++) // Simulating multiple charging attempts
        {
            phone.Charge();
        }
    }
}