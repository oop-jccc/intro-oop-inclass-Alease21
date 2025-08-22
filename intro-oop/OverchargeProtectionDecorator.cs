namespace intro_oop;

internal class OverchargeProtectionDecorator : IBattery
{
    private readonly IBattery _decoratedBattery;
    private int _chargeLevel = 0;

    public OverchargeProtectionDecorator(IBattery decoratedBattery)
    {
        _decoratedBattery = decoratedBattery;
    }

    public void ChargeUp()
    {
        if (_chargeLevel >= 85)
        {
            Console.WriteLine("Overcharge protection activated. Stopping charge.");
            return;
        }
        _decoratedBattery.ChargeUp();
        _chargeLevel += 10;  // Simulating charge level increase
    }
}