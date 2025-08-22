# In-Class Assignment: Implement an Overcharge Protection Decorator for Battery

## Objective

In this exercise, you will implement an "Overcharge Protection" feature for the `Battery` class using the Decorator pattern. This decorator will halt the battery charging process if the charge level reaches 85%.

## Starter Code

```csharp

interface IBattery

{

    void ChargeUp();

}

// TODO: Implement the IBattery interface in Battery

internal class Battery

{

    public void ChargeUp()

    {

        Console.WriteLine("Battery is charging.");

    }

}

// TODO: Implement OverchargeProtectionDecorator and make it implement IBattery

internal class OverchargeProtectionDecorator

{

    // TODO: Add a field for the decorated battery and initialize it in the constructor

    // private readonly IBattery _decoratedBattery;

    // TODO: Add a field to keep track of the charge level

    // private int _chargeLevel = 0;

    // TODO: Implement the constructor to accept an IBattery object

    // public OverchargeProtectionDecorator(IBattery decoratedBattery) { }

    // TODO: Implement the ChargeUp method

    public void ChargeUp()

    {

        // TODO: Add logic to stop charging at 85%

        // if (_chargeLevel >= 85) { ... }

        // TODO: Call the decorated battery's ChargeUp method

        // _decoratedBattery.ChargeUp();

        // TODO: Update the charge level

        // _chargeLevel += 10;

    }

}

```

## Steps

1. Start by implementing the `IBattery` interface in the `Battery` class if not already done.

2. Next, implement the `OverchargeProtectionDecorator` class to follow the `IBattery` interface.

3. Initialize the `OverchargeProtectionDecorator` with a `Battery` object in its constructor.

4. In the `ChargeUp` method of `OverchargeProtectionDecorator`, implement the logic to stop charging the battery when the charge level reaches 85%.

After you've implemented the code, run the program to test your "Overcharge Protection" feature. Good luck!