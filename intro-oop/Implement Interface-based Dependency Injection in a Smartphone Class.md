# Assignment: Implement Interface-based (Polymorphic) Dependency Injection in a Smartphone Class

## Objective

Your task is to refactor the provided `Smartphone` class to use interface-based Dependency Injection. You'll start with a basic version of the code, where the `Camera` and `Battery` classes are directly used. 

## Starter Code

```csharp

interface IBattery

{

    void ChargeUp();

}

interface ICamera

{

    void Capture();

}

internal class Battery //TODO: implement IBattery

{

    public void ChargeUp()

    {

        Console.WriteLine("Battery is charging.");

    }

}

internal class Camera //TODO: implement ICamera

{

    public void Capture()

    {

        Console.WriteLine("Photo taken.");

    }

}

internal class Smartphone

{

    // TODO: Use interfaces here instead of concrete classes

    private readonly Camera _camera = new();

    private readonly Battery _battery = new();

    // TODO: Inject dependencies through interfaces

    public Smartphone(/*Camera camera, Battery battery*/)

    {

        // TODO: Initialize members

    }

    public void TakePhoto()

    {

        _camera.Capture();

    }

    public void Charge()

    {

        _battery.ChargeUp();

    }

}

```

## Steps

1. Implement the `IBattery` interface in the `Battery` class.

2. Implement the `ICamera` interface in the `Camera` class.

3. Modify the `Smartphone` class to use interfaces (`ICamera` and `IBattery`) instead of concrete classes for its member variables.

4. Change the constructor of `Smartphone` to accept interface types and initialize the member variables.

5. In the `Main` method, create instances of `Camera` and `Battery` that implement their respective interfaces. Inject these instances when creating a `Smartphone` object.

6. Run the program and verify that the `TakePhoto` and `Charge` methods work as expected.

## Expected Output

After you've successfully completed the steps, running the program should produce the following output:

```

Photo taken.

Battery is charging.

```
