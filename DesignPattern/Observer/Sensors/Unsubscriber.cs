namespace DesignPattern.Observer.Sensors;

public sealed class Unsubscriber : IDisposable
{
    private readonly List<IObserver<float>> _observers = new();
    private readonly IObserver<float> _observer;
    
    public Unsubscriber(List<IObserver<float>> list, IObserver<float> observer)
    {
        _observer = observer;
        _observers = list;
    }
    
    public void Dispose()
        => _observers.Remove(_observer);
}