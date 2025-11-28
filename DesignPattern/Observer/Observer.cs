// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; } = userName;
        private ISubject? _subject;

        public void AddSubscriber(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);

            if (subject == _subject) _subject = null;
        }

        public void Update(string availability)
        {
            Console.WriteLine("Product availability changed to " + availability + " for user " + UserName);
        }
    }
}
