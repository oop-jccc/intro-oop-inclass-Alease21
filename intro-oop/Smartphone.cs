namespace intro_oop;

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