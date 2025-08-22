# Assignment: Implement Dependency Injection in a Smartphone Class

## Objective

Learn to implement Dependency Injection by refactoring the given `Smartphone` class. In this assignment, you'll be provided with initial code that directly instantiates dependencies (`Camera` and `Battery`). Your task is to modify the code to inject these dependencies through the constructor.

## Starter Code

```csharp

private static void Main()

{

    //TODO: Uncomment the following lines and inject the dependencies

    // Camera camera = new Camera();

    // Battery battery = new Battery();

    var phone = new Smartphone(/*camera, battery*/);

    phone.TakePhoto();

    phone.Charge();

}

internal class Smartphone

{

    // TODO: remove instantiation of Camera and Battery

    private readonly Camera _camera = new();

    private readonly Battery _battery = new();

    // TODO: inject dependencies here

    public Smartphone(/*Camera camera, Battery battery*/)

    {

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

1. Uncomment the lines in the `Main()` method where `Camera` and `Battery` are being instantiated.

2. Modify the constructor of the `Smartphone` class to accept `Camera` and `Battery` objects as parameters.

3. Remove the direct instantiation of `_camera` and `_battery` inside the `Smartphone` class.

4. Initialize `_camera` and `_battery` with the objects passed through the constructor.

5. Test the program by running it. Verify that the `TakePhoto()` and `Charge()` methods are working as expected.

## Expected Output

When you run the modified program, it should output:

```

Photo taken.

Battery is charging.

```

## Tips

- Ensure that the dependencies are injected through the constructor, and not directly instantiated within the class.

- Make sure to modify the `Main()` method to pass the dependencies when creating a `Smartphone` object.

