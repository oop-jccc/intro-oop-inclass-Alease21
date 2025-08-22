namespace intro_oop;

internal class Smartphone
{
    private readonly ICamera _camera;
    private readonly IBattery _battery;

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