namespace intro_oop;

internal class Smartphone
{
    // TODO: remove instantiation of Camera and Battery
    private readonly ICamera _camera;
    private readonly IBattery _battery;

    // TODO: inject dependencies here
    public Smartphone(ICamera camera, IBattery battery)
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