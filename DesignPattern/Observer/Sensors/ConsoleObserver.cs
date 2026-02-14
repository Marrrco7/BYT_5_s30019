namespace DesignPattern.Observer.Sensors;

public class ConsoleObserver(string name) : IObserver<float>
{
    public void OnNext(float value) => Console.WriteLine($"{name} got temp: {value}");
    public void OnError(Exception error) => Console.WriteLine($"{name} error: {error.Message}");
    public void OnCompleted() => Console.WriteLine($"{name} completed");
}