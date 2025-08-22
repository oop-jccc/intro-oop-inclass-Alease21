namespace intro_oop;

internal class OverchargeProtectionDecorator // TODO: Make it implement IBattery
{
    // TODO: Add a field for the decorated battery and initialize it in the constructor

    private int _chargeLevel = 0;

    // TODO: Implement the constructor to accept an IBattery object

    public void ChargeUp()
    {
        if (_chargeLevel >= 85)
        {
            Console.WriteLine("Overcharge protection activated. Stopping charge.");
            return;
        }

        // TODO: Call the decorated battery's ChargeUp method

        _chargeLevel += 10;
    }
}