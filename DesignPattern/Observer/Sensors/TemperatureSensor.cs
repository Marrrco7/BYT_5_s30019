namespace DesignPattern.Observer.Sensors;

public class TemperatureSensor : IObservable<float>
{
    private readonly List<IObserver<float>> _observers = new();
    private float _temp;

    public IDisposable Subscribe(IObserver<float> observer)
    {
        _observers.Add(observer);
        observer.OnNext(_temp);
        return new Unsubscriber(_observers, observer);
    }

    public void SetTemperature(float temp)
    {
        _temp = temp;
        foreach (var observer in _observers) observer.OnNext(_temp);
    }

    public void Fail(Exception ex)
    {
        foreach (var observer in _observers) observer.OnError(ex);
        _observers.Clear();
    }

    public void Complete()
    {
        foreach (var observer in _observers) observer.OnCompleted();
        _observers.Clear();
    }
}