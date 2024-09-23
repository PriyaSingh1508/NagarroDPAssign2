using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class NotificationService : ISubject
    {
        private static NotificationService _instance;
        private static readonly object _lock = new object();
        private readonly Dictionary<string, List<IObserver>> _observers = new Dictionary<string, List<IObserver>>();

        private NotificationService() { }

        public static NotificationService GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new NotificationService();
                    }
                }
            }
            return _instance;
        }

        public void Subscribe(IObserver observer, string channel)
        {
            if (!_observers.ContainsKey(channel))
            {
                _observers[channel] = new List<IObserver>();
            }
            _observers[channel].Add(observer);
        }

        public void Unsubscribe(IObserver observer, string channel)
        {
            if (_observers.ContainsKey(channel))
            {
                _observers[channel].Remove(observer);
            }
        }

        public void NotifyObservers(string channel, string subject, string message)
        {
            if (_observers.ContainsKey(channel))
            {
                foreach (var observer in _observers[channel])
                {
                    observer.Update(channel, subject, message);
                }
            }
        }
    }
}
