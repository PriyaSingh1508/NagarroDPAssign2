namespace NotificationSystem
{
    public interface ISubject
    {
        void Subscribe(IObserver observer, string channel);
        void Unsubscribe(IObserver observer, string channel);
        void NotifyObservers(string channel, string subject, string message);
    }

}
