namespace intro_oop;

internal class Battery : IBattery
{
    public void ChargeUp()
    {
        Console.WriteLine("Battery is charging.");
    }
}