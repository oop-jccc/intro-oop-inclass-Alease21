namespace intro_oop;

internal class Smartphone
{
    // TODO: Use interfaces instead of concrete classes.
    private readonly Camera _camera;
    private readonly Battery _battery;

    // TODO: Use interfaces instead of concrete classes.
    public Smartphone(Camera camera, Battery battery)
    {
        _camera = camera;
        _battery = battery;
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